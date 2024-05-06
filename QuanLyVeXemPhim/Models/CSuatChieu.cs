using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CSuatChieu
    {
        private string iDSuatChieu;
        private CPhim phim;
        private CRapChieuPhim rap;
        private CPhongChieu phong;
        private int soLuongVe;
        private DateTime thoiGianChieu;
        private int soLuongConLai;
        private string trangThai;

        public string IDSuatChieu { get => iDSuatChieu; set => iDSuatChieu = value; }
        public int SoLuongVe { get => soLuongVe; set => soLuongVe = value; }
        public DateTime ThoiGianChieu { get => thoiGianChieu; set => thoiGianChieu = value; }
        public int SoLuongConLai { get => soLuongConLai; set => soLuongConLai = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        internal CPhim Phim { get => phim; set => phim = value; }
        internal CRapChieuPhim Rap { get => rap; set => rap = value; }
        internal CPhongChieu Phong { get => phong; set => phong = value; }

        public CSuatChieu()
        {
        }

        public CSuatChieu(string iDSuatChieu, CPhim phim, CRapChieuPhim rap, CPhongChieu phong, int soLuongVe, DateTime thoiGianChieu, int soLuongConLai, string trangThai)
        {
            this.iDSuatChieu = iDSuatChieu;
            this.phim = phim;
            this.rap = rap;
            this.phong = phong;
            this.soLuongVe = soLuongVe;
            this.thoiGianChieu = thoiGianChieu;
            this.soLuongConLai = soLuongConLai;
            this.trangThai = trangThai;
        }

        public override bool Equals(object? obj)
        {
            return obj is CSuatChieu suatChieu &&
                   IDSuatChieu == suatChieu.IDSuatChieu;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IDSuatChieu);
        }


    }
}
