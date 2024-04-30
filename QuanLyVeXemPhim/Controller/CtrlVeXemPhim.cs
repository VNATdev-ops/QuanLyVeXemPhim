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
    internal class CtrlVeXemPhim
    {
        SqlConnection cnn = null;
        public CtrlVeXemPhim()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }

        public List<CVeXemPhim> findall()
        {
            string sql = "select * from vexemphim";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CVeXemPhim> arrs = new List<CVeXemPhim>();

            while (reader.Read())
            {
                CVeXemPhim s = new CVeXemPhim();
                s.IDVe = reader.GetString(0);
                s.ThanhVien = new CThanhVien();
                s.ThanhVien.IDThanhVien = reader.GetString(1);
                s.Phim = new CPhim();
                s.Phim.IDPhim = reader.GetString(2);
                s.SuatChieu = new CSuatChieu();
                s.SuatChieu.IDSuatChieu = reader.GetString(3);
                s.ChoNgoi = new CChoNgoi();
                s.ChoNgoi.IDChoNgoi = reader.GetString(4);
                s.GiaVe = (int)reader.GetDecimal(5);
                s.TinhTrang = reader.GetString(6);

                arrs.Add(s);

            }
            reader.Close();
            return arrs;
        }


        public bool insert (CVeXemPhim obj)
        {
            try 
            {
                string sql = "insert into vexemphim values (@idve, @idThanhVien, @idPhim, @idSuatChieu, @idChoNgoi, @giaVe, @tinhTrang)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idThanhVien", obj.ThanhVien.IDThanhVien);
                cmd.Parameters.AddWithValue("@idPhim", obj.Phim.IDPhim);
                cmd.Parameters.AddWithValue("@idSuatChieu", obj.SuatChieu.IDSuatChieu);
                cmd.Parameters.AddWithValue("@idChoNgoi", obj.ChoNgoi.IDChoNgoi);
                cmd.Parameters.AddWithValue("@giaVe", obj.GiaVe);
                cmd.Parameters.AddWithValue("@tinhTrang", obj.TinhTrang);
                cmd.Parameters.AddWithValue("@idve", int.Parse(obj.IDVe));

                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }
        }

        public bool update(CVeXemPhim obj)
        {
            try
            {
                string sql = "update vexemphim set idThanhVien=@idThanhVien, idPhim=@idPhim, idSuatChieu=@idSuatChieu, idChoNgoi=@idChoNgoi, giaVe=@giaVe, tinhTrang=@tinhTrang where                 string sql = \"update vexemphim set , idThanhVien=@idThanhVien, idPhim=@idPhim, idSuatChieu=@idSuatChieu, idChoNgoi=@idChoNgoi, giaVe=@giaVe, tinhTrang=@tinhTrang where idve=@idve";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idThanhVien", obj.ThanhVien.IDThanhVien);
                cmd.Parameters.AddWithValue("@idPhim", obj.Phim.IDPhim);
                cmd.Parameters.AddWithValue("@idSuatChieu", obj.SuatChieu.IDSuatChieu);
                cmd.Parameters.AddWithValue("@idChoNgoi", obj.ChoNgoi.IDChoNgoi);
                cmd.Parameters.AddWithValue("@giaVe", obj.GiaVe);
                cmd.Parameters.AddWithValue("@tinhTrang", obj.TinhTrang);
                cmd.Parameters.AddWithValue("@idve", int.Parse(obj.IDVe));

                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }

        }
    }
}
