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
        private int veID;
        private int suatChieuID;
        private int choNgoiID;
        private float giaVe;
        private string tinhTrang;
        private int nguoiDungID;
        private int phimID;

        public int VeID { get => veID; set => veID = value; }
        public int SuatChieuID { get => suatChieuID; set => suatChieuID = value; }
        public int ChoNgoiID { get => choNgoiID; set => choNgoiID = value; }
        public float GiaVe { get => giaVe; set => giaVe = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int NguoiDungID { get => nguoiDungID; set => nguoiDungID = value; }
        public int PhimID { get => phimID; set => phimID = value; }

        public CVeXemPhim(int veID, int suatChieuID, int choNgoiID, float giaVe, string tinhTrang, int nguoiDungID, int phimID)
        {
            this.veID = veID;
            this.suatChieuID = suatChieuID;
            this.choNgoiID = choNgoiID;
            this.giaVe = giaVe;
            this.tinhTrang = tinhTrang;
            this.nguoiDungID = nguoiDungID;
            this.phimID = phimID;
        }

        public CVeXemPhim()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CVeXemPhim phim &&
                   veID == phim.veID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(veID);
        }
    }
}
