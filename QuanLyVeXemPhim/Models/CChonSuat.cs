using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CChonSuat
    {
        private CPhim phim;
        private CRapChieuPhim rap;
        private CSuatChieu suatChieu;

        internal CPhim Phim { get => phim; set => phim = value; }
        internal CRapChieuPhim Rap { get => rap; set => rap = value; }
        internal CSuatChieu SuatChieu { get => suatChieu; set => suatChieu = value; }

        public CChonSuat(CPhim phim, CRapChieuPhim rap, CSuatChieu suatChieu)
        {
            this.phim = phim;
            this.rap = rap;
            this.suatChieu = suatChieu;
        }

        public CChonSuat()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CChonSuat suat &&
                   EqualityComparer<CPhim>.Default.Equals(phim, suat.phim) &&
                   EqualityComparer<CRapChieuPhim>.Default.Equals(rap, suat.rap) &&
                   EqualityComparer<CSuatChieu>.Default.Equals(suatChieu, suat.suatChieu);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(phim, rap, suatChieu);
        }
    }
}
