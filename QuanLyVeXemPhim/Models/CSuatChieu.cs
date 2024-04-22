using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CSuatChieu
    {
        private int idSuatChieu;
        private int iDPhim;
        private int iDRap;
        private int soLuongVe;
        private DateTime thoiGianChieu;
        private int soLuongConLai;
        private string trangThai;
        //iDPhong

        public int IdSuatChieu { get => idSuatChieu; set => idSuatChieu = value; }
        public int IDPhim { get => iDPhim; set => iDPhim = value; }
        public int IDRap { get => iDRap; set => iDRap = value; }
        public int SoLuongVe { get => soLuongVe; set => soLuongVe = value; }
        public DateTime ThoiGianChieu { get => thoiGianChieu; set => thoiGianChieu = value; }
        public int SoLuongConLai { get => soLuongConLai; set => soLuongConLai = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public CSuatChieu(int idSuatChieu, int iDPhim, int iDRap, int soLuongVe, DateTime thoiGianChieu, int soLuongConLai, string trangThai)
        {
            this.idSuatChieu = idSuatChieu;
            this.iDPhim = iDPhim;
            this.iDRap = iDRap;
            this.soLuongVe = soLuongVe;
            this.thoiGianChieu = thoiGianChieu;
            this.soLuongConLai = soLuongConLai;
            this.trangThai = trangThai;
        }
        public CSuatChieu()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CSuatChieu suatChieu &&
                   idSuatChieu == suatChieu.idSuatChieu;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(idSuatChieu);
        }
    }
}
