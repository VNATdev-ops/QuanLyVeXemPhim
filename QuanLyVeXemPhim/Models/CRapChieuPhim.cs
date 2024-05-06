using QuanLyVeXemPhim.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CRapChieuPhim
    {
        private string iDRap;
        private string tenRap;
        private string diaChi;
        private int soLuongPhong;
        private string logo;

        public string IDRap { get => iDRap; set => iDRap = value; }
        public string TenRap { get => tenRap; set => tenRap = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int SoLuongPhong { get => soLuongPhong; set => soLuongPhong = value; }
        public string Logo { get => logo; set => logo = value; }

        public CRapChieuPhim(string iDRap, string tenRap, string diaChi, int soLuongPhong, string logo)
        {
            this.iDRap = iDRap;
            this.tenRap = tenRap;
            this.diaChi = diaChi;
            this.soLuongPhong = soLuongPhong;
            this.logo = logo;
        }

        public CRapChieuPhim()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CRapChieuPhim phim &&
                   iDRap == phim.iDRap;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(iDRap);
        }
        public override string ToString()
        {
            return iDRap + " _ " + tenRap;
        }
    }
}
