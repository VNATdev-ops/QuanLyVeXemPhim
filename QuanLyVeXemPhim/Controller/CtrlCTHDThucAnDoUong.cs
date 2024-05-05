using QuanLyVeXemPhim.Models;
using QuanLyVeXemPhim.Utils;
using QuanLyVeXemPhim.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Controller
{
    internal class CtrlCTHDThucAnDoUong
    {
        SqlConnection cnn = null;
        CtrlHoaDon ctrHoaDon = new CtrlHoaDon();
        CtrlThucAnDoUong ctrSP = new CtrlThucAnDoUong();
        List<CThucAnDoUong> dsSP = new List<CThucAnDoUong>(); 
        List<CHoaDon> dsHD = new List<CHoaDon>();

        public CtrlCTHDThucAnDoUong()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }

        public List<CCTHDThucAnDoUong> findAll()
        {
            string sql = "select * from cthd_thucandouong";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CCTHDThucAnDoUong> arrs = new List<CCTHDThucAnDoUong>();
            while (reader.Read())
            {
                CCTHDThucAnDoUong s = new CCTHDThucAnDoUong();
                s.HoaDon = new CHoaDon();
                s.SanPham = new CThucAnDoUong();
                dsHD = ctrHoaDon.findCriteria(reader.GetString(0));
                s.HoaDon = dsHD[0];
                dsSP = ctrSP.findCriteria(reader.GetString(1));
                s.SanPham = dsSP[0];
                s.SoLuong = reader.GetInt32(2);
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }
        public bool insert(CCTHDThucAnDoUong obj)
        {
            try
            {
                string sql = "insert into cthd_thucandouong (idhoadon, idsanpham, soluong) values (@idhoadon, @idsanpham, @soluong)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idhoadon", obj.HoaDon.IDHoaDon);
                cmd.Parameters.AddWithValue("@idsanpham", obj.SanPham.IDSanPham);
                cmd.Parameters.AddWithValue("@soluong", obj.SoLuong);

                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm chi tiết hóa đơn thức ăn đồ uống vào cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }
        public bool delete_bySingleID(string dk)
        {
            try
            {
                string sql = "delete from cthd_thucandouong where idhoadon = @dk or idsanpham = @dk";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("@dk", dk);
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa sản phẩm khỏi cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }
        public bool delete_byBothID(string idHD, string idSP)
        {
            try
            {
                string sql = "delete from cthd_thucandouong where idhoadon = @idHD or idsanpham = @idSP";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("@idHD", idHD);
                cmd.Parameters.AddWithValue("@idSP", idSP);
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa sản phẩm khỏi cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }
        public List<CCTHDThucAnDoUong> findCriteria(string dk)
        {
            string sql = "select * from cthd_thucandouong where idhoadon = @dk";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dk", dk);
            SqlDataReader reader = cmd.ExecuteReader();
            List<CCTHDThucAnDoUong> arrs = new List<CCTHDThucAnDoUong>();
            while (reader.Read())
            {
                CCTHDThucAnDoUong s = new CCTHDThucAnDoUong();
                s.HoaDon = GetHoaDonById(reader.GetString(0));
                s.SanPham = GetSanPhamById(reader.GetString(1));
                s.SoLuong = reader.GetInt32(2);
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

        private CHoaDon GetHoaDonById(string idHoaDon)
        {
            dsHD = ctrHoaDon.findCriteria(idHoaDon);
            CHoaDon hd = dsHD[0];
            return hd;
        }

        private CThucAnDoUong GetSanPhamById(string idSanPham)
        {
            dsSP = ctrSP.findCriteria(idSanPham);
            CThucAnDoUong sp = dsSP[0];
            return sp;
        }

    }
}
