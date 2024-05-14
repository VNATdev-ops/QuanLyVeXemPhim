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
    internal class CtrlCTHD
    {
        SqlConnection cnn = null;
        CtrlHoaDon ctrHoaDon = new CtrlHoaDon();
        CtrlSanPham ctrSP = new CtrlSanPham();
        List<CSanPham> dsSP = new List<CSanPham>(); 
        List<CHoaDon> dsHD = new List<CHoaDon>();

        public CtrlCTHD()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }

        public List<CCTHD> findAll()
        {
            string sql = "select * from cthd";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CCTHD> arrs = new List<CCTHD>();
            while (reader.Read())
            {
                CCTHD s = new CCTHD();
                s.HoaDon = new CHoaDon();
                s.SanPham = new CSanPham();
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
        public bool insert(CCTHD obj)
        {
            try
            {
                string sql = "insert into cthd (idhoadon, idsanpham, soluong) values (@idhoadon, @idsanpham, @soluong)";
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
                string sql = "delete from cthd where idhoadon = @dk or idsanpham = @dk";
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
                string sql = "delete from cthd where idhoadon = @idHD or idsanpham = @idSP";
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
        public List<CCTHD> findCriteria(string dk)
        {
            string sql = "select * from cthd where idhoadon = @dk";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dk", dk);
            SqlDataReader reader = cmd.ExecuteReader();
            List<CCTHD> arrs = new List<CCTHD>();
            while (reader.Read())
            {
                CCTHD s = new CCTHD();
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

        private CSanPham GetSanPhamById(string idSanPham)
        {
            dsSP = ctrSP.findCriteria(idSanPham);
            CSanPham sp = dsSP[0];
            return sp;
        }

    }
}
