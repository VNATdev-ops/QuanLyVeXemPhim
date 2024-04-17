using QuanLyVeXemPhim.Models;
using QuanLyVeXemPhim.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Controller
{
    internal class CtrlPhim
    {
        SqlConnection cnn = null;

        public CtrlPhim()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        // phương thức truy vấn vào toàn bộ nhân viên
        public List<CPhim> findAll()
        {
            string sql = "select top 5 * from phim";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();

            List<CPhim> arrs = new List<CPhim>();
            while (reader.Read())
            {
                CPhim s = new CPhim();
                //s.TenPhim = reader.GetString(0);
                //s.NgayCP = reader.GetDateTime(1);
                //s.DaoDien = reader.GetString(2);
                //s.TheLoaiPhim = reader.GetString(3);
                //s.PhimID = (int)reader.GetDecimal(4);

                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

        public bool update(CPhim obj)
        {
            try
            {
                string sql = "update phim set tenphim =@tenphim, daodien=@daodien " +
                "ngaycp=@ngaycp,  theoloaiphim = @theloaiphim, where phimid=@phimid";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@tenphim", obj.TenPhim);
                cmd.Parameters.AddWithValue("@ngaycp", obj.NgayCP);
                cmd.Parameters.AddWithValue("@daodien", obj.DaoDien);
                cmd.Parameters.AddWithValue("@theloaiphim", obj.TheLoaiPhim);
                cmd.Parameters.AddWithValue("@phimid", obj.PhimID);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch
            { return false; }

        }

        public bool delete(CPhim obj)
        {
            try
            {
                string sql = "delete from phim, where phimid= @phimid";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@phimid", obj.PhimID);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch
            { return false; }
        }

        public bool insert(CPhim obj)
        {
            try
            {
                string sql = "insert into phim values (@phimid, @tenphim, @ngaycp, @daodien, @theloaiphim)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@tenphim", obj.TenPhim);
                cmd.Parameters.AddWithValue("@ngaycp", obj.NgayCP);
                cmd.Parameters.AddWithValue("@daodien", obj.DaoDien);
                cmd.Parameters.AddWithValue("@theloaiphim", obj.TheLoaiPhim);
                cmd.Parameters.AddWithValue("@phimid", obj.PhimID);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch
            {
                return false;
            }
        }

        // tim san pham theo dieu kien
        public List<CPhim> findCriteria(string dk)
        {
            string sql = " select * from phim " +
            "where tenphim like @dk or phimid like @dk or daodien like @dk or theloaiphim like @dk ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@dk", "%" + dk + "%");
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CPhim> arrs = new List<CPhim>();
            while (reader.Read())
            {
                CPhim s = new CPhim();
                s.PhimID = (int)reader.GetDecimal(0);
                s.TenPhim = reader.GetString(1);
                s.NgayCP = reader.GetDateTime(2);
                s.DaoDien = reader.GetString(3);
                s.TheLoaiPhim = reader.GetString(4);
                //them vao ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

    }
}
