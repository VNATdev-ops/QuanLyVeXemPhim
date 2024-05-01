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
            string sql = "select top 10 * from lichsutichdiem";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CLichSuTichDiem> arrs = new List<CLichSuTichDiem>();
            while (reader.Read())
            {
                CLichSuTichDiem s = new CLichSuTichDiem();
                s.IDLichSu = reader.GetString(0);
                s.SoDiemTichLuy = (int)reader.GetDecimal(1);
                s.ThoiGianTichLuy = reader.GetDateTime(2);
                s.TongDiemTichLuy = (int)reader.GetDecimal(3);
                s.ThanhVien.IDThanhVien = reader.GetString(4);
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
                string sql = "insert into lichsutichdiem values (@idlichsu,@sodiemtichluy,@thoigiantichluy,@tongdiemtichluy,@idthanhvien)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idlichsu", obj.IDLichSu);
                cmd.Parameters.AddWithValue("@sodiemtichluy", obj.SoDiemTichLuy);
                cmd.Parameters.AddWithValue("@thoigiantichluy", obj.ThoiGianTichLuy);
                cmd.Parameters.AddWithValue("@tongdiemtichluy", obj.TongDiemTichLuy);
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
                string sql = "update lichsutichdiem set sodiemtichluy=@sodiemtichluy, thoigiantichluy=@thoigiantichluy,tongdiemtichluy=@tongdiemtichluy, where idthanhvien=@idthanhvien";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@sodiemtichluy", obj.SoDiemTichLuy);
                cmd.Parameters.AddWithValue("@thoigiantichluy", obj.ThoiGianTichLuy);
                cmd.Parameters.AddWithValue("@tongdiemtichluy", obj.TongDiemTichLuy);
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
            //cho phép tìm theo tên or mã sp hoặc nước sản xuất or đon vị tính
            string sql = "select * from lichsutichdiem where idlichsu like @dk or idthanhvien like @dk or tongdiemtichluy like @dk";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CLichSuTichDiem> arrs = new List<CLichSuTichDiem>();
            while (reader.Read())
            {
                CLichSuTichDiem s = new CLichSuTichDiem();
                s.IDLichSu = reader.GetString(0);
                s.SoDiemTichLuy = (int)reader.GetDecimal(1);
                s.ThoiGianTichLuy = reader.GetDateTime(2);
                s.TongDiemTichLuy = (int)reader.GetDecimal(3);
                s.ThanhVien.IDThanhVien = reader.GetString(4);
                // thêm vào ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }
    }

    
}
