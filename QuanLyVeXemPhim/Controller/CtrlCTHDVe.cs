using QuanLyVeXemPhim.Models;
using QuanLyVeXemPhim.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Controller
{
    internal class CtrlCTHDVe
    {
        SqlConnection cnn = null;
        public CtrlCTHDVe()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        public bool insert(CCTHDVe obj)
        {
            try
            {
                string sql = "insert into cthd_ve (idhoadon, idve, soluong) values (@idhoadon, @idve, @soluong)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idhoadon", obj.HoaDon.IDHoaDon);
                cmd.Parameters.AddWithValue("@idve", obj.Ve.IDVe);
                cmd.Parameters.AddWithValue("@soluong", obj.SoLuong);

                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool delete(CCTHDVe obj)
        {
            try
            {
                string sql = "delete from cthd_ve where idve =@idve";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("@idve", obj.Ve.IDVe);
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa sản phẩm khỏi cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }
        public List<CCTHDVe> findCriteria(string dk)
        {
            string sql = "select * from cthd_ve where idhoadon like @dk";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dk", dk);
            SqlDataReader reader = cmd.ExecuteReader();
            List<CCTHDVe> arrs = new List<CCTHDVe>();
            while (reader.Read())
            {
                CCTHDVe s = new CCTHDVe();
                s.HoaDon = new CHoaDon(); 
                s.Ve = new CVeXemPhim(); 
                s.HoaDon.IDHoaDon = reader.GetString(0);
                s.Ve.IDVe = reader.GetString(1);
                s.SoLuong = reader.GetInt32(2);
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

    }
}
