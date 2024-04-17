using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace QuanLyVeXemPhim.Models
{
    internal class CPhim
    {
        private int phimID;
        private string tenPhim;
        private DateTime ngayCP;
        private string daoDien;
        private string theLoaiPhim;

        public int PhimID { get => phimID; set => phimID = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public DateTime NgayCP { get => ngayCP; set => ngayCP = value; }
        public string DaoDien { get => daoDien; set => daoDien = value; }
        public string TheLoaiPhim { get => theLoaiPhim; set => theLoaiPhim = value; }

        public CPhim(int phimID, string tenPhim, DateTime ngayCP, string daoDien, string theLoaiPhim)
        {
            this.phimID = phimID;
            this.tenPhim = tenPhim;
            this.ngayCP = ngayCP;
            this.daoDien = daoDien;
            this.theLoaiPhim = theLoaiPhim;
        }
        public CPhim()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is CPhim phim &&
                   phimID == phim.phimID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(phimID);
        }

        //public override bool Equals(object? obj)
        //{
        //    return obj is CPhim phim &&
        //           phimID == phim.phimID;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(phimID);
        //}


    }
}
