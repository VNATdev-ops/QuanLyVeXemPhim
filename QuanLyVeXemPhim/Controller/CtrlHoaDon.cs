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
    internal class CtrlHoaDon
    {
        SqlConnection cnn = null;
        public CtrlHoaDon()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        public List<CHoaDon> findAll()
        {
            string sql = "select * from hoadon";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CHoaDon> arrs = new List<CHoaDon>();
            while (reader.Read())
            {
                CHoaDon s = new CHoaDon();
                s.NhanVien = new CNhanVien();
                s.ThanhVien = new CThanhVien();

                s.IDHoaDon = reader.GetString(0);
                s.NgayXuatHD = reader.GetDateTime(1);
                if (!reader.IsDBNull(2))
                {
                    s.NhanVien.IDNhanVien = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    s.ThanhVien.IDThanhVien = reader.GetString(3);
                }

                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

        public bool insert(CHoaDon obj)
        {
            try
            {
                string sql = "insert into hoadon (idhoadon, ngayxuathd, idnhanvien, idthanhvien) values (@idhoadon, @ngayxuathd, @idnhanvien, @idthanhvien)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("@idhoadon", obj.IDHoaDon);
                cmd.Parameters.AddWithValue("@ngayxuathd", obj.NgayXuatHD);
                //cmd.Parameters.AddWithValue("@idnhanvien", obj.NhanVien.IDNhanVien);

                if (obj.NhanVien != null && obj.NhanVien.IDNhanVien != null)
                {
                    cmd.Parameters.AddWithValue("@idnhanvien", obj.NhanVien.IDNhanVien);
                }
                else
                {
                    cmd.Parameters.Add("@idnhanvien", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                // Kiểm tra và xử lý trường hợp thanh vien hoặc IDThanhVien là null
                if (obj.ThanhVien != null && obj.ThanhVien.IDThanhVien != null)
                {
                    cmd.Parameters.AddWithValue("@idthanhvien", obj.ThanhVien.IDThanhVien);
                }
                else
                {
                    cmd.Parameters.Add("@idthanhvien", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lưu thông tin hóa đơn vào cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }


        public bool update(CHoaDon obj)
        {
            try
            {
                string sql = "update hoadon set ngayxuathd =@ngayxuathd, nhanvien =@nhanvien, thanhvien =@thanhvien " +
                    "where idhoadon =@idhoadon";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection= cnn;
                cmd.Parameters.AddWithValue("@ngayxuathd", obj.NgayXuatHD);
                cmd.Parameters.AddWithValue("@nhanvien", obj.NhanVien.IDNhanVien);
                if (obj.ThanhVien.IDThanhVien == null)
                {
                    cmd.Parameters.Add("@thanhvien", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@thanhvien", obj.ThanhVien.IDThanhVien);
                }
                cmd.Parameters.AddWithValue("@idhoadon", obj.IDHoaDon);
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật thông tin hóa đơn vào cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        public bool delete(CHoaDon obj)
        {
            try
            {
                string sql = "delete from hoadon where idhoadon =@idhoadon";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idhoadon", obj.IDHoaDon);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa thông tin hóa đơn khỏi cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }
    }
}
