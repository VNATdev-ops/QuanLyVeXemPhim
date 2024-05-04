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
        private CNhanVien nhanVien;
        private CThanhVien thanhVien;

        public string IDHoaDon { get => iDHoaDon; set => iDHoaDon = value; }
        public DateTime NgayXuatHD { get => ngayXuatHD; set => ngayXuatHD = value; }
        internal CNhanVien NhanVien { get => nhanVien; set => nhanVien = value; }
        internal CThanhVien ThanhVien { get => thanhVien; set => thanhVien = value; }

        public CHoaDon(string iDHoaDon, DateTime ngayXuatHD, CNhanVien nhanVien, CThanhVien thanhVien)
        {
            this.iDHoaDon = iDHoaDon;
            this.ngayXuatHD = ngayXuatHD;
            this.nhanVien = nhanVien;
            this.thanhVien = thanhVien;
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
