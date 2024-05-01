using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CCTHDThucAnDoUong
    {
        private CHoaDon hoaDon;
        private CThucAnDoUong sanPham;
        private int soLuong;

        internal CHoaDon HoaDon { get => hoaDon; set => hoaDon = value; }
        internal CThucAnDoUong SanPham { get => sanPham; set => sanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public CCTHDThucAnDoUong(CHoaDon hoaDon, CThucAnDoUong sanPham, int soLuong)
        {
            this.hoaDon = hoaDon;
            this.sanPham = sanPham;
            this.soLuong = soLuong;
        }

        public CCTHDThucAnDoUong()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CCTHDThucAnDoUong uong &&
                   EqualityComparer<CHoaDon>.Default.Equals(hoaDon, uong.hoaDon) &&
                   EqualityComparer<CThucAnDoUong>.Default.Equals(sanPham, uong.sanPham);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(hoaDon, sanPham);
        }
    }
}
