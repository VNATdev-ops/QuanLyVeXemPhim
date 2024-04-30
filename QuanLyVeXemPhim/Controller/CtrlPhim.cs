using QuanLyVeXemPhim.Models;
using QuanLyVeXemPhim.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public List<CPhim> findAll()
        {
            string sql = "select * from phim";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CPhim> arrs = new List<CPhim>();

            while (reader.Read())
            {
                CPhim s = new CPhim();
                s.IDPhim = reader.GetString(0);
                s.TenPhim = reader.GetString(1);
                s.TheLoai = reader.GetString(2);
                s.DaoDien = reader.GetString(3);
                s.MoTa = reader.GetString(4);
                if (!reader.IsDBNull(5))
                {
                    s.HinhAnh = reader.GetString(5);
                }
                s.NgayPH = reader.GetDateTime(6);
                s.DoDai = reader.GetInt32(7);
                s.TrangThai = reader.GetString(8);
                s.DinhDang = reader.GetString(9);

                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

        public bool insert(CPhim obj)
        {
            try
            {
                string sql = "insert into phim values (@idphim, @tenphim, @theloai, @daodien, @mota, " +
                             "@hinhanh, @ngayphathanh, @dodai, @trangthai, @dinhdang)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("@idphim", obj.IDPhim);
                cmd.Parameters.AddWithValue("@tenphim", obj.TenPhim);
                cmd.Parameters.AddWithValue("@theloai", obj.TheLoai);
                cmd.Parameters.AddWithValue("@daodien", obj.DaoDien);
                cmd.Parameters.AddWithValue("@mota", obj.MoTa);
                if (obj.HinhAnh == null)
                {
                    cmd.Parameters.Add("@hinhanh", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@hinhanh", obj.HinhAnh);
                }

                cmd.Parameters.AddWithValue("@ngayphathanh", obj.NgayPH);
                cmd.Parameters.AddWithValue("@dodai", obj.DoDai);
                cmd.Parameters.AddWithValue("@trangthai", obj.TrangThai);
                cmd.Parameters.AddWithValue("@dinhdang", obj.DinhDang);
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm phim vào cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        public bool update(CPhim obj)
        {
            try
            {
                string sql = "update phim set tenphim = @tenphim, theloai = @theloai, daodien = @daodien, mota = @mota, " +
                             "hinhanh = @hinhanh, ngayphathanh = @ngayphathanh, dodai = @dodai, trangthai = @trangthai, dinhdang = @dinhdang " +
                             "where idphim = @idphim";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("@tenphim", obj.TenPhim);
                cmd.Parameters.AddWithValue("@theloai", obj.TheLoai);
                cmd.Parameters.AddWithValue("@daodien", obj.DaoDien);
                cmd.Parameters.AddWithValue("@mota", obj.MoTa);
                if (obj.HinhAnh == null)
                {
                    cmd.Parameters.Add("@hinhanh", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@hinhanh", obj.HinhAnh);
                }
                cmd.Parameters.AddWithValue("@ngayphathanh", obj.NgayPH);
                cmd.Parameters.AddWithValue("@dodai", obj.DoDai);
                cmd.Parameters.AddWithValue("@trangthai", obj.TrangThai);
                cmd.Parameters.AddWithValue("@dinhdang", obj.DinhDang);
                cmd.Parameters.AddWithValue("@idphim", obj.IDPhim);

                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật phim vào cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        public bool delete(CPhim obj)
        {
            try
            {
                string sql = "delete from phim where idphim =@idphim";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idphim", obj.IDPhim);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa phim khỏi cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        public List<CPhim> findCriteria(string dk)
        {
            string sql = "select * from phim " +
                "where idphim like @dk " +
                "or tenphim like @dk or theloai like @dk " +
                "or daodien like @dk or trangthai like @dk " +
                "or dinhdang like @dk";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@dk", "%" + dk + "%");
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CPhim> arrs = new List<CPhim>();

            while (reader.Read())
            {
                CPhim s = new CPhim();
                s.IDPhim = reader.GetString(0);
                s.TenPhim = reader.GetString(1);
                s.TheLoai = reader.GetString(2);
                s.DaoDien = reader.GetString(3);
                s.MoTa = reader.GetString(4);
                if (!reader.IsDBNull(5))
                {
                    s.HinhAnh = reader.GetString(5);
                }
                s.NgayPH = reader.GetDateTime(6);
                s.DoDai = reader.GetInt32(7);
                s.TrangThai = reader.GetString(8);
                s.DinhDang = reader.GetString(9);

                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }
    }
}
