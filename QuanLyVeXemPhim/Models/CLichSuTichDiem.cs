using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    public class CLichSuTichDiem // Thay đổi từ internal sang public
    {
        private string iDLichSu;
        private int soDiemTichLuy;
        private DateTime thoiGianTichLuy;
        private int tongDiemTichLuy;
        private CThanhVien thanhVien;

        public string IDLichSu { get => iDLichSu; set => iDLichSu = value; }
        public int SoDiemTichLuy { get => soDiemTichLuy; set => soDiemTichLuy = value; }
        public DateTime ThoiGianTichLuy { get => thoiGianTichLuy; set => thoiGianTichLuy = value; }
        public int TongDiemTichLuy { get => tongDiemTichLuy; set => tongDiemTichLuy = value; }
        public CThanhVien ThanhVien { get => thanhVien; set => thanhVien = value; }

        public CLichSuTichDiem(string iDLichSu, int soDiemTichLuy, DateTime thoiGianTichLuy, int tongDiemTichLuy, CThanhVien thanhVien)
        {
            this.iDLichSu = iDLichSu;
            this.soDiemTichLuy = soDiemTichLuy;
            this.thoiGianTichLuy = thoiGianTichLuy;
            this.tongDiemTichLuy = tongDiemTichLuy;
            this.thanhVien = thanhVien;
        }

        public CLichSuTichDiem()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CLichSuTichDiem diem &&
                   iDLichSu == diem.iDLichSu;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(iDLichSu);
        }

        // Phương thức khác
        //public CLichSuTichDiem(int lichSuID, int nguoiDungID)
        //{
        //    this.lichSuID = lichSuID;
        //    this.nguoiDungID = nguoiDungID;
        //}

    }
}
