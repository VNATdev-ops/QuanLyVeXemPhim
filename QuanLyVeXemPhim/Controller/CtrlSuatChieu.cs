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
    internal class CtrlSuatChieu
    {
        SqlConnection cnn = null;

        List<CPhim> dsPhim = new List<CPhim>();
        List<CRapChieuPhim> dsRap = new List<CRapChieuPhim>();
        List<CPhongChieu> dsPhong = new List<CPhongChieu>();

        CtrlPhim ctrPhim = new CtrlPhim();
        CtrlRapChieuPhim ctrRapChieuPhim = new CtrlRapChieuPhim();
        CtrlPhongChieu ctrPhongChieu = new CtrlPhongChieu();
        public CtrlSuatChieu()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
        public List<CSuatChieu> findAll()
        {
            string sql = "select * from suatchieu";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CSuatChieu> arrs = new List<CSuatChieu>();
            while (reader.Read())
            {
                CSuatChieu s = new CSuatChieu();
                s.IDSuatChieu = reader.GetString(0);
                dsPhim = ctrPhim.findCriteria(reader.GetString(1));
                s.Phim = dsPhim[0];
                dsRap = ctrRapChieuPhim.findCriteria(reader.GetString(2));
                s.Rap = dsRap[0];
                dsPhong = ctrPhongChieu.findCriteria(reader.GetString(3));
                s.Phong = dsPhong[0];
                s.SoLuongVe = reader.GetInt32(4);
                s.ThoiGianChieu = reader.GetDateTime(5);
                s.SoLuongConLai = reader.GetInt32(6);
                s.TrangThai = reader.GetString(7);
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }
        public bool insert(CSuatChieu obj)
        {
            try
            {
                string sql = "insert into suatchieu values (@IDSuatChieu, @IDPhim, @IDRap, @IDPhong, @SoLuongVe, @ThoiGianChieu, @SoLuongConLai, @TrangThai)";
                SqlCommand cmd = new SqlCommand(sql);

                cmd.Parameters.AddWithValue("@IDSuatChieu", obj.IDSuatChieu);
                cmd.Parameters.AddWithValue("@IDPhim", obj.Phim.IDPhim);
                cmd.Parameters.AddWithValue("@IDRap", obj.Rap.IDRap);
                cmd.Parameters.AddWithValue("@IDPhong", obj.Phong.IDPhong);
                cmd.Parameters.AddWithValue("@SoLuongVe", obj.SoLuongVe);
                cmd.Parameters.AddWithValue("@ThoiGianChieu", obj.ThoiGianChieu + "");
                cmd.Parameters.AddWithValue("@SoLuongConLai", obj.SoLuongConLai);
                cmd.Parameters.AddWithValue("@TrangThai", obj.TrangThai);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm suất chiếu vào cơ sở dữ liệu: " + ex.Message);
                return false;
            }

        }
        public bool delete(CSuatChieu obj)
        {
            try
            {
                string sql = "delete from suatchieu where IDSuatChieu=@IDSuatChieu";
                SqlCommand cmd = new SqlCommand(sql);

                cmd.Parameters.AddWithValue("@IDSuatChieu", obj.IDSuatChieu);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);

            }
            catch
            {
                return false;
            }
        }
        public bool update(CSuatChieu obj)
        {
            try
            {
                string sql = "update suatchieu set IDPhim=@IDPhim, IDRap=@IDRap, IDPhong=@IDPhong, SoLuongVe=@SoLuongVe, ThoiGianChieu=@ThoiGianChieu, SoLuongConLai=@SoLuongConLai, TrangThai=@TrangThai where IDSuatChieu=@IDSuatChieu";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@IDSuatChieu", obj.IDSuatChieu);
                cmd.Parameters.AddWithValue("@IDPhim", obj.Phim.IDPhim);
                cmd.Parameters.AddWithValue("@IDRap", obj.Rap.IDRap);
                cmd.Parameters.AddWithValue("@IDPhong", obj.Phong.IDPhong);
                cmd.Parameters.AddWithValue("@SoLuongVe", obj.SoLuongVe);
                cmd.Parameters.AddWithValue("@ThoiGianChieu", obj.ThoiGianChieu + "");
                cmd.Parameters.AddWithValue("@SoLuongConLai", obj.SoLuongConLai);
                cmd.Parameters.AddWithValue("@TrangThai", obj.TrangThai);
                cmd.Connection = cnn;
                int n = cmd.ExecuteNonQuery();
                return (n > 0);

            }
            catch
            {
                return false;
            }
        }
        public List<CSuatChieu> findCriteria(string dk)
        {
            string sql = "select * from suatchieu " +
                "where idsuatchieu like @dk " +
                "or idphim like @dk " +
                "or idrap like @dk " +
                "or idphong like @dk";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@dk", "%" + dk + "%");
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CSuatChieu> arrs = new List<CSuatChieu>();

            while (reader.Read())
            {
                CSuatChieu s = new CSuatChieu();
                s.IDSuatChieu = reader.GetString(0);
                dsPhim = ctrPhim.findCriteria(reader.GetString(1));
                s.Phim = dsPhim[0];
                dsRap = ctrRapChieuPhim.findCriteria(reader.GetString(2));
                s.Rap = dsRap[0];
                dsPhong = ctrPhongChieu.findCriteria(reader.GetString(3));
                s.Phong = dsPhong[0];
                s.SoLuongVe = reader.GetInt32(4);
                s.ThoiGianChieu = reader.GetDateTime(5);
                s.SoLuongConLai = reader.GetInt32(6);
                s.TrangThai = reader.GetString(7);
                arrs.Add(s);
            }
            reader.Close();
            return arrs;
        }
    }
}
