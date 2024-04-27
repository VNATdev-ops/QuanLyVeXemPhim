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
        public List<CVeXemPhim> findAll()
        {
            string sql = "select * from VeXemPhim";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();

            List<CVeXemPhim> arrs = new List<CVeXemPhim>();
            while (reader.Read())
            {
                CVeXemPhim s = new CVeXemPhim();
                s.VeID = reader.GetInt32(0);
                s.SuatChieuID = reader.GetInt32(1);
                s.ChoNgoiID = reader.GetInt32(2);
                s.GiaVe = reader.GetFloat(3);
                s.TinhTrang = reader.GetString(4);
                s.NguoiDungID = reader.GetInt32(5);
                s.PhimID = reader.GetInt32(6);

                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }

        public bool update(CVeXemPhim obj)
        {
            try
            {
                string sql = "update vexemphim set veid = @veid, suatchieuid = @suatchieuid, " +
             "chongoiid = @chongoiid, giave = @giave, tinhtrang = @tinhtrang, " +
             "nguoidungid = @nguoidungid, where phimid = @phimid";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@", obj.SuatChieuID);
                cmd.Parameters.AddWithValue("@", obj.ChoNgoiID);
                cmd.Parameters.AddWithValue("@", obj.GiaVe);
                cmd.Parameters.AddWithValue("@", obj.TinhTrang);
                cmd.Parameters.AddWithValue("@", obj.NguoiDungID);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch
            { return false; }
        }

        public bool delete(CVeXemPhim obj)
        {
            try
            {
                string sql = "delete from vexemphim where phimid = @phimid";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@phimid", obj.PhimID);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch
            { return false; }
        }

        public bool insert(CVeXemPhim obj)
        {
            try
            {
                string sql = "insert into phim values (@veid, @suatchieuid, @chongoiid, @giave, @tinhtrang, @nguoidungid, @phimid)";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@veid", obj.VeID);
                cmd.Parameters.AddWithValue("@suatchieuid", obj.SuatChieuID);
                cmd.Parameters.AddWithValue("@chongoiid", obj.ChoNgoiID);
                cmd.Parameters.AddWithValue("@giave", obj.GiaVe);
                cmd.Parameters.AddWithValue("@tinhtrang", obj.TinhTrang);
                cmd.Parameters.AddWithValue("@nguoidungid", obj.NguoiDungID);
                cmd.Parameters.AddWithValue("@phimid", obj.PhimID);

                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch
            {
                return false;
            }
        }


    }
}
