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
    internal class CtrlNhanVien
    {
        SqlConnection cnn = null;
        public CtrlNhanVien()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }

        // phương thức truy vấn toàn bộ nhân viên
        public List<CNhanVien> findall()
        {
            string sql = "select * from nhanvien";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CNhanVien> arrs = new List<CNhanVien>();
            while (reader.Read())
            {
                CNhanVien s = new CNhanVien();
                s.IDNhanVien = reader.GetString(0);
                s.TenNV = reader.GetString(1);
                s.MatKhau = reader.GetString(2);
                s.NgaySinh = reader.GetDateTime(3);
                s.GioiTinh = reader.GetString(4);
                s.Sdt = reader.GetString(5);
                s.Email = reader.GetString(6);
                s.ChucVu = reader.GetString(7);

                // thêm vào ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

        public CNhanVien findUser(string manv, string pw)
        {
            string sql = "select * from nhanvien where IDNhanVien=@IDNhanVien and sodt=@pw ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@pw", pw);

            SqlDataReader reader = cmd.ExecuteReader();

            CNhanVien nv = new CNhanVien();
            if (reader.Read())
            {
                nv.IDNhanVien = reader.GetString(0);
                nv.TenNV = reader.GetString(1);
                nv.MatKhau = reader.GetString(2);
                nv.NgaySinh = reader.GetDateTime(3);
                nv.GioiTinh = reader.GetString(4);
                nv.Sdt = reader.GetString(5);
                nv.Email = reader.GetString(6);
                nv.ChucVu = reader.GetString(7);

            }
            else
            {
                nv = null;
            }
            reader.Close();
            return nv;
        }

        public bool update(CNhanVien obj)
        {
            try
            {
                string sql = "update nhanvien set TenNV=@TenNV, MatKhau=@MatKhau, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, Sdt=@Sdt, Email=@Email, ChucVu=@ChucVu where IDNhanVien=@IDNhanVien";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@IDNhanVien", obj.IDNhanVien);
                cmd.Parameters.AddWithValue("@TenNV", obj.TenNV);
                cmd.Parameters.AddWithValue("@MatKhau", obj.MatKhau);
                cmd.Parameters.AddWithValue("@NgaySinh", obj.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", obj.GioiTinh);
                cmd.Parameters.AddWithValue("@Sdt", obj.Sdt);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                cmd.Parameters.AddWithValue("@ChucVu", obj.ChucVu);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);

            }
            catch
            {
                return false;
            }
        }
        public bool insert(CNhanVien obj)
        {
            try
            {
                string sql = "insert into nhanvien values (@IDNhanVien, @TenNV, @MatKhau, @NgaySinh, @GioiTinh, @Sdt, @Email, @Chucvu )";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@IDNhanVien", obj.IDNhanVien);
                cmd.Parameters.AddWithValue("@TenNV", obj.TenNV);
                cmd.Parameters.AddWithValue("@MatKhau", obj.MatKhau);
                cmd.Parameters.AddWithValue("@NgaySinh", obj.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", obj.GioiTinh);
                cmd.Parameters.AddWithValue("@Sdt", obj.Sdt);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                cmd.Parameters.AddWithValue("@ChucVu", obj.ChucVu);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch
            {
                return false;
            }
        }
        public bool delete(CNhanVien obj)
        {
            try
            {
                string sql = "delete from nhanvien where IDNhanVien=@IDNhanVien";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@IDNhanVien", obj.IDNhanVien);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);

            }
            catch
            {
                return false;
            }
        }
        public List<CNhanVien> findCriteria(string DK)
        {//cho phép tìm theo tên or mã sp hoặc nước sản xuất or đon vị tính
            string sql = " select * from nhanvien where TenNV like @dk or IDNhanVien like @dk or Sdt like @dk or ChucVu like @dk ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CNhanVien> arrs = new List<CNhanVien>();
            while (reader.Read())
            {
                CNhanVien s = new CNhanVien();
                s.IDNhanVien = reader.GetString(0);
                s.TenNV = reader.GetString(1);
                s.MatKhau = reader.GetString(2);
                s.NgaySinh = reader.GetDateTime(3);
                s.GioiTinh = reader.GetString(4);
                s.Sdt = reader.GetString(5);
                s.Email = reader.GetString(6);
                s.ChucVu = reader.GetString(7);
                // thêm vào ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

    }
}
