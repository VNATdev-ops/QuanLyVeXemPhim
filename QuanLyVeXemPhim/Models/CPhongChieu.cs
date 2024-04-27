using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CPhongChieu
    {
        private int idPhong;
        private int idRap;
        private string tenPhong;
        private string loaiPhong;
        private int soLuongghe;

        public CPhongChieu()
        {
        }

        public int IdPhong { get => idPhong; set => idPhong = value; }
        public int IdRap { get => idRap; set => idRap = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public int SoLuongghe { get => soLuongghe; set => soLuongghe = value; }

        public CPhongChieu(int idPhong)
        {
            this.idPhong = idPhong;
        }

        public override bool Equals(object? obj)
        {
            return obj is CPhongChieu chieu &&
                   idPhong == chieu.idPhong;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idPhong);
        }
    }
}
