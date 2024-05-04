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
