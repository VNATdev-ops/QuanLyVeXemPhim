using QuanLyVeXemPhim.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Controller
{
    internal class CtrlCTHDThucAnDoUong
    {
        SqlConnection cnn = null;
        public CtrlCTHDThucAnDoUong()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
    }
}
