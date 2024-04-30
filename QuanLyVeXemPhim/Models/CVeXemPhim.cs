using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CVeXemPhim
    {
        private string iDVe;
        private CThanhVien thanhVien;
        private CPhim phim;
        private CSuatChieu suatChieu;
        private CChoNgoi choNgoi;
        private decimal giaVe;
        private string tinhTrang;

        public string IDVe { get => iDVe; set => iDVe = value; }
        public decimal GiaVe { get => giaVe; set => giaVe = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        internal CThanhVien ThanhVien { get => thanhVien; set => thanhVien = value; }
        internal CPhim Phim { get => phim; set => phim = value; }
        internal CSuatChieu SuatChieu { get => suatChieu; set => suatChieu = value; }
        internal CChoNgoi ChoNgoi { get => choNgoi; set => choNgoi = value; }
        public string ThanhVien1 { get; }
        public string Phim1 { get; }
        public string Suatchieu { get; }
        public string ChoNgoi1 { get; }
        public string V { get; }

        public CVeXemPhim()
        {
        }

        public CVeXemPhim(string veID, CThanhVien thanhVien, CPhim phim, CSuatChieu suatChieu, CChoNgoi choNgoi, decimal giaVe, string tinhTrang)
        {
            this.iDVe = veID;
            this.thanhVien = thanhVien;
            this.phim = phim;
            this.suatChieu = suatChieu;
            this.choNgoi = choNgoi;
            this.giaVe = giaVe;
            this.tinhTrang = tinhTrang;
        }

        public CVeXemPhim(string idVe, string thanhVien1, string phim1, string suatchieu, string choNgoi1, string v, string tinhtrang)
        {
            iDVe = idVe;
            ThanhVien1 = thanhVien1;
            Phim1 = phim1;
            Suatchieu = suatchieu;
            ChoNgoi1 = choNgoi1;
            V = v;
            tinhTrang = tinhtrang;
        }

        public override bool Equals(object? obj)
        {
            return obj is CVeXemPhim phim &&
                   iDVe == phim.iDVe;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(iDVe);
        }
    }
}
