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
    internal class CtrlRapChieuPhim
    {
        SqlConnection cnn = null;
        public CtrlRapChieuPhim()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }

        public List<CRapChieuPhim> findall()
        {
            string sql = "select * from rapchieuphim";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CRapChieuPhim> arrs = new List<CRapChieuPhim>();
            while (reader.Read())
            {
                CRapChieuPhim s = new CRapChieuPhim();
                s.IDRap = reader.GetString(0);
                s.TenRap = reader.GetString(1);
                s.DiaChi = reader.GetString(2);
                s.SoLuongPhong = reader.GetInt32(3);
                if (!reader.IsDBNull(4))
                {
                    s.Logo = reader.GetString(4);
                }
                // thêm vào ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

        public bool insert(CRapChieuPhim obj)
        {
            try
            {
                string sql = "insert into rapchieuphim values (@idrap, @tenrap, @diachi, @soluongphong, @logo)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idrap", obj.IDRap);
                cmd.Parameters.AddWithValue("@tenrap", obj.TenRap);
                cmd.Parameters.AddWithValue("@diachi", obj.DiaChi);
                cmd.Parameters.AddWithValue("@soluongphong", obj.SoLuongPhong);
                cmd.Parameters.AddWithValue("@logo", obj.Logo);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }

        }

        public bool update(CRapChieuPhim obj)
        {
            try
            {
                string sql = "update rapchieuphim set tenrap=@tenrap, diachi=@diachi,soluongphong=@soluongphong,logo=@logo where idrap=@idrap";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idrap", obj.IDRap);
                cmd.Parameters.AddWithValue("@tenrap", obj.TenRap);
                cmd.Parameters.AddWithValue("@diachi", obj.DiaChi);
                cmd.Parameters.AddWithValue("@soluongphong", obj.SoLuongPhong);
                cmd.Parameters.AddWithValue("@logo", obj.Logo);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }

        }

        public bool delete(CRapChieuPhim obj)
        {
            try
            {
                string sql = "delete from rapchieuphim where idrap = @idrap";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@idrap", obj.IDRap);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch { return false; }
        }

        public List<CRapChieuPhim> findCriteria(string DK)
        {
            string sql = "select * from rapchieuphim where idrap like @dk or tenrap like @dk or diachi like @dk";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dk", "%" + DK + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            List<CRapChieuPhim> arrs = new List<CRapChieuPhim>();
            while (reader.Read())
            {
                CRapChieuPhim s = new CRapChieuPhim();
                s.IDRap = reader.GetString(0);
                s.TenRap = reader.GetString(1);
                s.DiaChi = reader.GetString(2);
                s.SoLuongPhong = reader.GetInt32(3);
                s.Logo = reader.GetString(4);
                // thêm vào ds
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }
    }
}
