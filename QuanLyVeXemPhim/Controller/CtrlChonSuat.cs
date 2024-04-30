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
    internal class CtrlChonSuat
    {
        SqlConnection cnn = null;
        public CtrlChonSuat()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        public List<CChonSuat> findall()
        {
            string sql = "select * from ChonSuat";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CChonSuat> arrs = new List<CChonSuat>();
            while (reader.Read())
            {
                CChonSuat s = new CChonSuat();
                s.Phim = new CPhim();
                s.Phim.IDPhim = reader.GetString(0);
                s.Rap = new CRapChieuPhim();
                s.Rap.IDRap = reader.GetString(1);
                s.SuatChieu = new CSuatChieu();
                s.SuatChieu.IDSuatChieu = reader.GetString(2);
                // thêm vào ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }
        // thêm thông tin chon suat
        public bool insert(CChonSuat obj)
        {
            try
            {
                string sql = "insert into chonsuat values (@maphim,@marap,@masuatchieu)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@maphim", obj.Phim.IDPhim);
                cmd.Parameters.AddWithValue("@marap", obj.Rap.IDRap);
                cmd.Parameters.AddWithValue("@masuatchieu", obj.SuatChieu.IDSuatChieu);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }

        }

        // cập nhật thông tin chon suat
        public bool update(CChonSuat obj)
        {
            try
            {
                string sql = "update chonsuat set  marap=@marap,masuatchieu=@masuatchieu, where maphim=@maphim,";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@maphim", obj.Phim.IDPhim);
                cmd.Parameters.AddWithValue("@marap", obj.Rap.IDRap);
                cmd.Parameters.AddWithValue("@masuatchieu", obj.SuatChieu.IDSuatChieu);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }
        }

        //xóa
        public bool delete(CChonSuat obj)
        {
            try
            {
                string sql = "delete from chonsuat where maphim=@maphim";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@maphim", obj.Phim.IDPhim);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }
        }

        //tìm sản phẩm theo ĐK
        public List<CChonSuat> findCriteria(string DK)
        {//cho phép tìm theo tên or mã sp hoặc nước sản xuất or đon vị tính
            string sql = "select * from chonsuat where maphim like @dk or marap like @dk or masuatchieu like @dk";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CChonSuat> arrs = new List<CChonSuat>();
            while (reader.Read())
            {
                CChonSuat s = new CChonSuat();
                s.Phim.IDPhim = reader.GetString(0);
                s.Rap.IDRap = reader.GetString(1);
                s.SuatChieu.IDSuatChieu = reader.GetString(2)
                // thêm vào ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }
    }
}
