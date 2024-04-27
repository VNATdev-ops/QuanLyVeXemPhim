using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CHoaDon
    {
        private string iDHoaDon;
        private DateTime ngayXuatHD;
        private double thanhTien;

        public string IDHoaDon { get => iDHoaDon; set => iDHoaDon = value; }
        public DateTime NgayXuatHD { get => ngayXuatHD; set => ngayXuatHD = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }

        public CHoaDon(string iDHoaDon, DateTime ngayXuatHD, double thanhTien)
        {
            this.iDHoaDon = iDHoaDon;
            this.ngayXuatHD = ngayXuatHD;
            this.thanhTien = thanhTien;
        }
        public CHoaDon()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CHoaDon don &&
                   iDHoaDon == don.iDHoaDon;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(iDHoaDon);
        }
    }
}
