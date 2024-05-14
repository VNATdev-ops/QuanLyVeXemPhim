using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CCTHD
    {
        private CHoaDon hoaDon;
        private CSanPham sanPham;
        private int soLuong;

        internal CHoaDon HoaDon { get => hoaDon; set => hoaDon = value; }
        internal CSanPham SanPham { get => sanPham; set => sanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public CCTHD(CHoaDon hoaDon, CSanPham sanPham, int soLuong)
        {
            this.hoaDon = hoaDon;
            this.sanPham = sanPham;
            this.soLuong = soLuong;
        }

        public CCTHD()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CCTHD uong &&
                   EqualityComparer<CHoaDon>.Default.Equals(hoaDon, uong.hoaDon) &&
                   EqualityComparer<CSanPham>.Default.Equals(sanPham, uong.sanPham);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(hoaDon, sanPham);
        }
    }
}
