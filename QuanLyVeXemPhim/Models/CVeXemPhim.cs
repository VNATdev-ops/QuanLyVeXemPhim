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
        private string veID;
        private CThanhVien thanhVien;
        private CPhim phim;
        private CSuatChieu suatChieu;
        private CChoNgoi choNgoi;
        private decimal giaVe;
        private string tinhTrang;

        public string VeID { get => veID; set => veID = value; }
        public decimal GiaVe { get => giaVe; set => giaVe = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        internal CThanhVien ThanhVien { get => thanhVien; set => thanhVien = value; }
        internal CPhim Phim { get => phim; set => phim = value; }
        internal CSuatChieu SuatChieu { get => suatChieu; set => suatChieu = value; }
        internal CChoNgoi ChoNgoi { get => choNgoi; set => choNgoi = value; }

        public CVeXemPhim()
        {
        }

        public CVeXemPhim(string veID, CThanhVien thanhVien, CPhim phim, CSuatChieu suatChieu, CChoNgoi choNgoi, decimal giaVe, string tinhTrang)
        {
            this.veID = veID;
            this.thanhVien = thanhVien;
            this.phim = phim;
            this.suatChieu = suatChieu;
            this.choNgoi = choNgoi;
            this.giaVe = giaVe;
            this.tinhTrang = tinhTrang;
        }

        public override bool Equals(object? obj)
        {
            return obj is CVeXemPhim phim &&
                   VeID == phim.VeID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(VeID);
        }
    }
}
