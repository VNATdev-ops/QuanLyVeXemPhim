using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CCTHDVe
    {
        private CHoaDon hoaDon;
        private CVeXemPhim ve;
        private int soLuong;

        internal CHoaDon HoaDon { get => hoaDon; set => hoaDon = value; }
        internal CVeXemPhim Ve { get => ve; set => ve = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public CCTHDVe(CHoaDon hoaDon, CVeXemPhim ve, int soLuong)
        {
            this.hoaDon = hoaDon;
            this.ve = ve;
            this.soLuong = soLuong;
        }

        public CCTHDVe()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CCTHDVe ve &&
                   EqualityComparer<CHoaDon>.Default.Equals(hoaDon, ve.hoaDon) &&
                   EqualityComparer<CVeXemPhim>.Default.Equals(this.ve, ve.ve);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(hoaDon, ve);
        }
    }
}
