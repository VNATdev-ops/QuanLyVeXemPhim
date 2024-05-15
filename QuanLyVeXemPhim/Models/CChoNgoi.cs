using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CChoNgoi
    {
        private string iDChoNgoi;
        private CPhongChieu phong;
        private string loaiChoNgoi;
        private string viTri;

        public string IDChoNgoi { get => iDChoNgoi; set => iDChoNgoi = value; }
        public string LoaiChoNgoi { get => loaiChoNgoi; set => loaiChoNgoi = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        internal CPhongChieu Phong { get => phong; set => phong = value; }

        public CChoNgoi()
        {
        }

        public CChoNgoi(string iDChoNgoi, CPhongChieu phong, string loaiChoNgoi, string viTri, string trangThai)
        {
            this.iDChoNgoi = iDChoNgoi;
            this.phong = phong;
            this.loaiChoNgoi = loaiChoNgoi;
            this.viTri = viTri;
        }

        public override bool Equals(object? obj)
        {
            return obj is CChoNgoi ngoi &&
                   iDChoNgoi == ngoi.iDChoNgoi;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(iDChoNgoi);
        }
    }
}
