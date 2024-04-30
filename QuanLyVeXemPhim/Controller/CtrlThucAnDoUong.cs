using QuanLyVeXemPhim.Models;
using QuanLyVeXemPhim.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Controller
{
    internal class CtrlThucAnDoUong
    {
        SqlConnection cnn = null;
        public CtrlThucAnDoUong()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }

        public List<CThucAnDoUong> findAll()
        {
            string sql = "select * from thucandouong";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CThucAnDoUong> arrs = new List<CThucAnDoUong>();
            while (reader.Read())
            {
                CThucAnDoUong s = new CThucAnDoUong();
                s.IDSanPham = reader.GetString(0);
                s.Loai = reader.GetString(1);
                s.TenSanPham = reader.GetString(2);
                s.Gia= reader.GetDecimal(3);
                if (!reader.IsDBNull(4))
                {
                    s.Hinh = reader.GetString(4);
                }

                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }
        public bool insert(CThucAnDoUong obj)
        {
            try
            {
                string sql = "insert into thucandouong values (@idsanpham, @loai, @tensanpham, @gia, @hinh)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("@idsanpham", obj.IDSanPham);
                cmd.Parameters.AddWithValue("@loai", obj.Loai);
                cmd.Parameters.AddWithValue("@tensanpham", obj.TenSanPham);
                cmd.Parameters.AddWithValue("@gia", obj.Gia);
                if (obj.Hinh == null)
                {
                    cmd.Parameters.Add("@hinh", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@hinh", obj.Hinh);
                }
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm sản phẩm vào cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        public bool update(CThucAnDoUong obj)
        {
            try
            {
                string sql = "update thucandouong set loai =@loai, tensanpham =@tensanpham, gia =@gia, hinh =@hinh" +
                " where idsanpham =@idsanpham";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("@loai", obj.Loai);
                cmd.Parameters.AddWithValue("@tensanpham", obj.TenSanPham);
                cmd.Parameters.AddWithValue("@gia", obj.Gia);
                if(obj.Hinh == null)
                {
                    cmd.Parameters.Add("@hinh", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@hinh", obj.Hinh);
                }
                cmd.Parameters.AddWithValue("@idsanpham", obj.IDSanPham);
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật phim vào cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        public bool delete(CThucAnDoUong obj)
        {
            try
            {
                string sql = "delete from thucandouong where idsanpham =@idsanpham";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("@idsanpham", obj.IDSanPham);
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa sản phẩm khỏi cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        public List<CThucAnDoUong> findCriteria(string dk)
        {
            string sql = "select * from thucandouong where idsanpham like @dk " +
                "or loai like @dk or tensanpham like @dk or gia like @dk";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dk", "%" + dk + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            List<CThucAnDoUong> arrs = new List<CThucAnDoUong>();
            while (reader.Read()) 
            { 
                CThucAnDoUong s = new CThucAnDoUong();
                s.IDSanPham = reader.GetString(0);
                s.Loai = reader.GetString(1);
                s.TenSanPham = reader.GetString(2);
                s.Gia = reader.GetDecimal(3);
                if(!reader.IsDBNull(4))
                    s.Hinh = reader.GetString(4);
                arrs.Add(s);
            }
            reader.Close(); 
            return arrs;
        }
    }
}
