using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Models
{
    internal class CLichSuTichDiem
    {
        private int lichSuID;
        private int soDiemTichLuy;
        private DateTime thoiGianTichLuy;
        private int tongDiemTichLuy;
        private int nguoiDungID;

        public CLichSuTichDiem()
        {
        }

        public CLichSuTichDiem(int lichSuID, int soDiemTichLuy, DateTime thoiGianTichLuy, int tongDiemTichLuy, int nguoiDungID)
        {
            this.lichSuID = lichSuID;
            this.soDiemTichLuy = soDiemTichLuy;
            this.thoiGianTichLuy = thoiGianTichLuy;
            this.tongDiemTichLuy = tongDiemTichLuy;
            this.nguoiDungID = nguoiDungID;
        }

        public CLichSuTichDiem(int lichSuID, int nguoiDungID)
        {
            this.lichSuID = lichSuID;
            this.nguoiDungID = nguoiDungID;
        }

        public override bool Equals(object? obj)
        {
            return obj is CLichSuTichDiem diem &&
                   lichSuID == diem.lichSuID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(lichSuID);
        }
    }
}
