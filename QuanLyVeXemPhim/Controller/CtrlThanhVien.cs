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
    internal class CtrlThanhVien
    {
        SqlConnection cnn = null;
        public CtrlThanhVien()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }

        public List<CThanhVien> findall()
        {
            string sql = "select * from thanhvien ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CThanhVien> arrs = new List<CThanhVien>();
            while (reader.Read())
            {
                CThanhVien s = new CThanhVien();
                s.IDThanhVien = reader.GetString(0);
                s.TenThanhVien = reader.GetString(1);
                s.MatKhau = reader.GetString(2);
                s.NgaySinh = reader.GetDateTime(3);
                s.GioiTinh = reader.GetString(4);
                s.KhuVuc = reader.GetString(5);
                s.Email = reader.GetString(6);
                // them vao ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }


        public bool insert(CThanhVien obj)
        {
            try
            {
                string sql = "insert into thanhvien values (@idthanhvien, @tentv, @matkhau, @ngaysinh, @gioitinh, @khuvuc, @email)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idthanhvien", obj.IDThanhVien);
                cmd.Parameters.AddWithValue("@tentv", obj.TenThanhVien);
                cmd.Parameters.AddWithValue("@matkhau", obj.MatKhau);
                cmd.Parameters.AddWithValue("@ngaysinh", obj.NgaySinh);
                cmd.Parameters.AddWithValue("@gioitinh", obj.GioiTinh);
                cmd.Parameters.AddWithValue("@khuvuc", obj.KhuVuc);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch
            {
                return false;
            }
        }

        public bool update(CThanhVien obj)
        {
            try
            {
                string sql = "update thanhvien set tenthanhvien=@tenthanhvien, matkhau=@matkhau, ngaysinh=@ngaysinh, gioitinh=@gioitinh, khuvuc=@khuvuc, email=@email where idthanhvien=@idthanhvien";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@tenthanhvien", obj.TenThanhVien);
                cmd.Parameters.AddWithValue("@matkhau", obj.MatKhau);
                cmd.Parameters.AddWithValue("@ngaysinh", obj.NgaySinh);
                cmd.Parameters.AddWithValue("@gioitinh", obj.GioiTinh);
                cmd.Parameters.AddWithValue("@khuvuc", obj.KhuVuc);
                cmd.Parameters.AddWithValue("@email", obj.NgaySinh);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);

            }
            catch
            {
                return false;
            }
        }

        public bool delete(CThanhVien obj)
        {
            try
            {
                string sql = "delete from thanhvien where idthanhvien=@idthanhvien";
                SqlCommand cmd = new SqlCommand(sql);

                cmd.Parameters.AddWithValue("@idthanhvien", obj.IDThanhVien);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch
            {
                return false;
            }
        }

        public List<CThanhVien> findCriteria(string DK)
        {//cho phép tìm theo tên or mã sp hoặc nước sản xuất or đon vị tính
            string sql = " SELECT * FROM ThanhVien WHERE TenThanhVien LIKE @dk OR Email LIKE @dk or idthanhvien like @dk ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CThanhVien> arrs = new List<CThanhVien>();
            while (reader.Read())
            {
                CThanhVien s = new CThanhVien();
                s.IDThanhVien = reader.GetString(0);
                s.TenThanhVien = reader.GetString(1);
                s.MatKhau = reader.GetString(2);
                s.NgaySinh = reader.GetDateTime(3);
                s.GioiTinh = reader.GetString(4);
                s.KhuVuc = reader.GetString(5);
                s.Email = reader.GetString(6);
                // thêm vào ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

    }
}
