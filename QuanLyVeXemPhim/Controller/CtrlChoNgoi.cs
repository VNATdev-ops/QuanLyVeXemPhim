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
    internal class CtrlChoNgoi
    {
        SqlConnection cnn = null;
        public CtrlChoNgoi()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        public List<CChoNgoi> findAll()
        {
            string sql = "select * from chongoi";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CChoNgoi> arrs = new List<CChoNgoi>();
            while (reader.Read())
            {
                CChoNgoi s = new CChoNgoi();
                s.IDChoNgoi = reader.GetString(0);
                s.Phong = new CPhongChieu();
                s.Phong.IDPhong = reader.GetString(1);
                s.LoaiChoNgoi = reader.GetString(2);
                s.ViTri = reader.GetString(3);
                s.TrangThai = reader.GetString(4);
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }
        public bool insert(CChoNgoi obj)
        {
            try
            {
                string sql = "insert into chongoi values (@IDChoNgoi, @IDPhong, @LoaiChoNgoi,@ViTri,@TrangThai)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@IDChoNgoi", obj.IDChoNgoi);
                cmd.Parameters.AddWithValue("@IDPhong", obj.Phong.IDPhong);
                cmd.Parameters.AddWithValue("@LoaiChoNgoi", obj.LoaiChoNgoi);
                cmd.Parameters.AddWithValue("@ViTri", obj.ViTri);
                cmd.Parameters.AddWithValue("@TrangThai", obj.TrangThai);

                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }

        }
        public bool delete(CChoNgoi obj)
        {
            try
            {
                string sql = "delete from chongoi where IDChoNgoi=@IDChoNgoi";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@IDChoNgoi", obj.IDChoNgoi);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }
        }
        public bool update(CChoNgoi obj)
        {
            try
            {
                string sql = "update chongoi set IDPhong=@IDPhong, LoaiChoNgoi=@LoaiChoNgoi, ViTri=@ViTri, TrangThai=@TrangThai where IDChoNgoi=@IDChoNgoi";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@IDChoNgoi", obj.IDChoNgoi);
                cmd.Parameters.AddWithValue("@IDPhong", obj.Phong.IDPhong);
                cmd.Parameters.AddWithValue("@LoaiChoNgoi", obj.LoaiChoNgoi);
                cmd.Parameters.AddWithValue("@ViTri", obj.ViTri);
                cmd.Parameters.AddWithValue("@TrangThai", obj.TrangThai);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }

        }
        public List<CChoNgoi> findCriteria(string DK)
        {
            string sql = " select * from chongoi where IDChoNgoi like @dk or IDPhong like @dk or LoaiChoNgoi like @dk or TrangThai like @dk or ViTri like @dk ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CChoNgoi> arrs = new List<CChoNgoi>();
            while (reader.Read())
            {
                CChoNgoi s = new CChoNgoi();
                s.IDChoNgoi = reader.GetString(0);
                s.Phong = new CPhongChieu();
                s.Phong.IDPhong = reader.GetString(1);
                s.LoaiChoNgoi = reader.GetString(2);
                s.ViTri = reader.GetString(3);
                s.TrangThai = reader.GetString(4);
                arrs.Add(s);

            }
            reader.Close();
            return arrs;
        }
    }
}