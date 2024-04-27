using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CRapChieuPhim
    {
        private int idRap;
        private string tenRap;
        private string diaChi;
        private int soLuongPhong;
        private string logo;

        public int IdRap { get => idRap; set => idRap = value; }
        public string TenRap { get => tenRap; set => tenRap = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int SoLuongPhong { get => soLuongPhong; set => soLuongPhong = value; }
        public string Logo { get => logo; set => logo = value; }

        public CRapChieuPhim(int idRap)
        {
            this.idRap = idRap;
        }

        public CRapChieuPhim()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CRapChieuPhim phim &&
                   idRap == phim.idRap;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idRap);
        }
    }
}
