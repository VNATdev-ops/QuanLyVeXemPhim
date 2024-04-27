using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CChonSuat
    {
        private int idPhim;
        private int idRap;
        private int idSuatchieu;

        public int IdPhim { get => idPhim; set => idPhim = value; }
        public int IdRap { get => idRap; set => idRap = value; }
        public int IdSuatchieu { get => idSuatchieu; set => idSuatchieu = value; }

        public CChonSuat(int idPhim, int idRap, int idSuatchieu)
        {
            this.idPhim = idPhim;
            this.idRap = idRap;
            this.idSuatchieu = idSuatchieu;
        }

        public CChonSuat()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CChonSuat suat &&
                   idPhim == suat.idPhim;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idPhim);
        }
    }
}
