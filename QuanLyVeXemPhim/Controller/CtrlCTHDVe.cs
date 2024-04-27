using QuanLyVeXemPhim.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeXemPhim.Controller
{
    internal class CtrlCTHDVe
    {
        SqlConnection cnn = null;
        public CtrlCTHDVe()
        {
            ConnectDB cnnDB = new ConnectDB();
            cnn = cnnDB.getConnection();
        }
    }
}
