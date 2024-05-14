using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing.Printing;
using QuanLyVeXemPhim.Views;

namespace QuanLyVeXemPhim.Models
{
    internal class CPhim
    {
        private string iDPhim;
        private string tenPhim;
        private string theLoai;
        private string daoDien;
        private string moTa;
        private string? hinhAnh;
        private DateTime ngayPH;
        private int doDai;
        private string trangThai;
        private string dinhDang;

        public string IDPhim { get => iDPhim; set => iDPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string DaoDien { get => daoDien; set => daoDien = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string? HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public DateTime NgayPH { get => ngayPH; set => ngayPH = value; }
        public int DoDai { get => doDai; set => doDai = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string DinhDang { get => dinhDang; set => dinhDang = value; }

        public CPhim(string iDPhim, string tenPhim, string theLoai, string daoDien, string moTa, string hinhAnh, DateTime ngayPH, int doDai, string trangThai, string dinhDang)
        {
            this.iDPhim = iDPhim;
            this.tenPhim = tenPhim;
            this.theLoai = theLoai;
            this.daoDien = daoDien;
            this.moTa = moTa;
            this.hinhAnh = hinhAnh;
            this.ngayPH = ngayPH;
            this.doDai = doDai;
            this.trangThai = trangThai;
            this.dinhDang = dinhDang;
        }

        public CPhim()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CPhim phim &&
                   iDPhim == phim.iDPhim;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(iDPhim);
        }

        public override string ToString()
        {
            return tenPhim;
        }
    }
}
