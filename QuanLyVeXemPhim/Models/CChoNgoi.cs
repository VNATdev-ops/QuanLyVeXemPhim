using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CChoNgoi
    {
        private int idChoNgoi;
        private int idPhong;
        private string loaiChoNgoi;
        private string viTri;
        private string trangThai;

        public CChoNgoi()
        {
        }

        public int IdChoNgoi { get => idChoNgoi; set => idChoNgoi = value; }
        public int IdPhong { get => idPhong; set => idPhong = value; }
        public string LoaiChoNgoi { get => loaiChoNgoi; set => loaiChoNgoi = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public CChoNgoi(int idChoNgoi)
        {
            this.idChoNgoi = idChoNgoi;
        }

        public override bool Equals(object? obj)
        {
            return obj is CChoNgoi ngoi &&
                   idChoNgoi == ngoi.idChoNgoi;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idChoNgoi);
        }
    }
}
