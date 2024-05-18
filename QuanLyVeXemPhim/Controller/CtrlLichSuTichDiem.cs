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
    internal class CtrlLichSuTichDiem
    {
        SqlConnection cnn = null;
        public CtrlLichSuTichDiem()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }

        // phương thức truy vấn toàn bộ sản phẩm
        public List<CLichSuTichDiem> findall()
        {
            string sql = "select * from lichsutichdiem";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CLichSuTichDiem> arrs = new List<CLichSuTichDiem>();
            while (reader.Read())
            {
                CLichSuTichDiem s = new CLichSuTichDiem();
                s.IDLichSu = reader.GetString(0);
                s.SoDiemTichLuy = reader.GetInt32(1);
                s.ThoiGianTichLuy = reader.GetDateTime(2);
                //s.TongDiemTichLuy = reader.GetInt32(3);
                // Khởi tạo đối tượng ThanhVien trước khi gán giá trị
                s.ThanhVien = new CThanhVien();
                s.ThanhVien.IDThanhVien = reader.GetString(3);
                // thêm vào ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;

        }

        //public List<CLichSuTichDiem> FindLichSuTichDiemByThanhVien(string idThanhVien)
        public List<CLichSuTichDiem> FindLichSuTichDiemByThanhVien(string idThanhVien)
        {
            string sql = "select * from lichsutichdiem where idthanhvien like @dk ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@dk", "%" + idThanhVien + "%");
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CLichSuTichDiem> arrs = new List<CLichSuTichDiem>();
            while (reader.Read())
            {
                CLichSuTichDiem s = new CLichSuTichDiem();
                s.ThanhVien = new CThanhVien();
                s.IDLichSu = reader.GetString(0);
                s.SoDiemTichLuy = reader.GetInt32(1);
                s.ThoiGianTichLuy = reader.GetDateTime(2);
                s.ThanhVien.IDThanhVien = reader.GetString(3);
                // thêm vào ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

        public bool insert(CLichSuTichDiem obj)
        {
            try
            {
                string sql = "insert into lichsutichdiem values (@idlichsu,@sodiemtichluy,@thoigiantichluy,@idthanhvien)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idlichsu", obj.IDLichSu);
                cmd.Parameters.AddWithValue("@sodiemtichluy", obj.SoDiemTichLuy);
                cmd.Parameters.AddWithValue("@thoigiantichluy", obj.ThoiGianTichLuy);
                cmd.Parameters.AddWithValue("@idthanhvien", obj.ThanhVien.IDThanhVien);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }
        }

        // cập nhật thông tin sản phẩm
        public bool update(CLichSuTichDiem obj)
        {
            try
            {
                string sql = "update lichsutichdiem set sodiemtichluy=@sodiemtichluy, thoigiantichluy=@thoigiantichluy, where idthanhvien=@idthanhvien";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@sodiemtichluy", obj.SoDiemTichLuy);
                cmd.Parameters.AddWithValue("@thoigiantichluy", obj.ThoiGianTichLuy);
                cmd.Parameters.AddWithValue("@idthanhvien", obj.ThanhVien.IDThanhVien);
                cmd.Parameters.AddWithValue("@idlichsu", obj.IDLichSu);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }

        }

        //xóa
        public bool delete(CLichSuTichDiem obj)
        {
            try
            {
                string sql = "delete from lichsutichdiem where idlichsu=@idlichsu";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idlichsu", obj.IDLichSu);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }
        }
        //tìm sản phẩm theo ĐK
        public List<CLichSuTichDiem> findCriteria(string DK)
        {
            string sql = "select * from lichsutichdiem where idlichsu like @dk or idthanhvien like @dk ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CLichSuTichDiem> arrs = new List<CLichSuTichDiem>();
            while (reader.Read())
            {
                CLichSuTichDiem s = new CLichSuTichDiem();
                s.ThanhVien = new CThanhVien();
                s.IDLichSu = reader.GetString(0);
                s.SoDiemTichLuy = reader.GetInt32(1);
                s.ThoiGianTichLuy = reader.GetDateTime(2);
                s.ThanhVien.IDThanhVien = reader.GetString(3);
                // thêm vào ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

     }


    }
