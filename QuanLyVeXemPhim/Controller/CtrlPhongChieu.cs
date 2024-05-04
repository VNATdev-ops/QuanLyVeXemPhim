using QuanLyVeXemPhim.Models;
using QuanLyVeXemPhim.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyVeXemPhim.Controller
{
    internal class CtrlPhongChieu
    {
        SqlConnection cnn = null;
        public CtrlPhongChieu()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }

        public List<CPhongChieu> findAll()
        {
            string sql = "select * from phongchieu";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CPhongChieu> arrs = new List<CPhongChieu>();

            while (reader.Read())
            {
                CPhongChieu s = new CPhongChieu();
                s.IDPhong = reader.GetString(0);

                CRapChieuPhim rap = new CRapChieuPhim();
                rap.IDRap = reader.GetString(1);
                s.Rap = rap;

                s.TenPhong = reader.GetString(2);
                s.LoaiPhong = reader.GetString(3);
                s.SoLuongGhe = reader.GetInt32(4);
                arrs.Add(s);
            }

            reader.Close();
            return arrs;
        }

        public bool insert(CPhongChieu obj)
        {
            try
            {
                string sql = "insert into phongchieu values (@idphong, @idrap, @tenphong, @loaiphong, @soluongghe)";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@idphong", obj.IDPhong);
                cmd.Parameters.AddWithValue("@idrap", obj.Rap.IDRap);
                cmd.Parameters.AddWithValue("@tenphong", obj.TenPhong);
                cmd.Parameters.AddWithValue("@loaiphong", obj.LoaiPhong);
                cmd.Parameters.AddWithValue("@soluongghe", obj.SoLuongGhe);
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm phòng chiếu vào cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        public bool update(CPhongChieu obj)
        {
            try
            {
                string sql = "update phongchieu set idrap = @idrap, tenphong = @tenphong, loaiphong = @loaiphong, soluongghe = @soluongghe where idphong = @idphong";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@idrap", obj.Rap.IDRap);
                cmd.Parameters.AddWithValue("@tenphong", obj.TenPhong);
                cmd.Parameters.AddWithValue("@loaiphong", obj.LoaiPhong);
                cmd.Parameters.AddWithValue("@soluongghe", obj.SoLuongGhe);
                cmd.Parameters.AddWithValue("@idphong", obj.IDPhong);
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật phòng chiếu vào cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        public bool delete(CPhongChieu obj)
        {
            try
            {
                string sql = "delete from phongchieu where idphong = @idphong";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@idphong", obj.IDPhong);
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa phòng chiếu khỏi cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        public List<CPhongChieu> findCriteria(string dk)
        {
            string sql = "select * from phongchieu " +
                         "where idphong like @dk " +
                         "or idrap like @dk or tenphong like @dk " +
                         "or loaiphong like @dk " +
                         "or soluongghe like @dk";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@dk", "%" + dk + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            List<CPhongChieu> arrs = new List<CPhongChieu>();

            while (reader.Read())
            {
                CPhongChieu s = new CPhongChieu();
                s.IDPhong = reader.GetString(0);

                CRapChieuPhim rap = new CRapChieuPhim();
                rap.IDRap = reader.GetString(1);
                s.Rap = rap;

                s.TenPhong = reader.GetString(2);
                s.LoaiPhong = reader.GetString(3);
                s.SoLuongGhe = reader.GetInt32(4);
                arrs.Add(s);
            }

            reader.Close();
            return arrs;
        }

    }
}
