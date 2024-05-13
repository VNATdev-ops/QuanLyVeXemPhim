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
    internal class CtrlSanPham
    {
        SqlConnection cnn = null;
        public CtrlSanPham()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }

        public List<CSanPham> findAll()
        {
            string sql = "select * from sanpham";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CSanPham> arrs = new List<CSanPham>();
            while (reader.Read())
            {
                CSanPham s = new CSanPham();
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
        public bool insert(CSanPham obj)
        {
            try
            {
                string sql = "insert into sanpham values (@idsanpham, @loai, @tensanpham, @gia, @hinh)";
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

        public bool update(CSanPham obj)
        {
            try
            {
                string sql = "update sanpham set loai =@loai, tensanpham =@tensanpham, gia =@gia, hinh =@hinh" +
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

        public bool delete(CSanPham obj)
        {
            try
            {
                string sql = "delete from sanpham where idsanpham =@idsanpham";
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

        public List<CSanPham> findCriteria(string dk)
        {
            string sql = "select * from sanpham where idsanpham like @dk " +
                "or loai like @dk or tensanpham like @dk or gia like @dk";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dk", "%" + dk + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            List<CSanPham> arrs = new List<CSanPham>();
            while (reader.Read()) 
            { 
                CSanPham s = new CSanPham();
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
