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
        public CtrlCTHDThucAnDoUong()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        //public List<CCTHDThucAnDoUong> findAll()
        //{
        //    string sql = "select * from cthd_thucandouong";
        //    SqlCommand cmd = new SqlCommand(sql);
        //    cmd.Connection = cnn;
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    List<CCTHDThucAnDoUong> arrs = new List<CCTHDThucAnDoUong>();
        //    while (reader.Read())
        //    {
        //        CCTHDThucAnDoUong cthd = new CCTHDThucAnDoUong();
        //        cthd.HoaDon.IDHoaDon = reader.GetString(0);
        //        cthd.SanPham.IDSanPham = reader.GetString(1);
        //        cthd.SoLuong = reader.GetInt32(2);
        //        arrs.Add(cthd);
        //    }
        //    reader.Close();
        //    return arrs;
        //}
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
        public bool delete(CCTHDThucAnDoUong obj)
        {
            try
            {
                string sql = "delete from cthd_thucandouong where idsanpham =@idsanpham";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("@idsanpham", obj.SanPham.IDSanPham);
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
                s.HoaDon = new CHoaDon(); 
                s.SanPham = new CThucAnDoUong(); 
                s.HoaDon.IDHoaDon = reader.GetString(0);
                s.SanPham.IDSanPham = reader.GetString(1);
                s.SoLuong = reader.GetInt32(2);
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

    }
}
