using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CPhongChieu
    {
        private string iDPhong;
        private CRapChieuPhim rap;
        private string tenPhong;
        private string loaiPhong;
        private int soLuongghe;

        public string IDPhong { get => iDPhong; set => iDPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public int SoLuongghe { get => soLuongghe; set => soLuongghe = value; }
        internal CRapChieuPhim Rap { get => rap; set => rap = value; }

        public CPhongChieu(string iDPhong, CRapChieuPhim rap, string tenPhong, string loaiPhong, int soLuongghe)
        {
            this.iDPhong = iDPhong;
            this.rap = rap;
            this.tenPhong = tenPhong;
            this.loaiPhong = loaiPhong;
            this.soLuongghe = soLuongghe;
        }

        public CPhongChieu()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CPhongChieu chieu &&
                   iDPhong == chieu.iDPhong;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(iDPhong);
        }
    }
}
