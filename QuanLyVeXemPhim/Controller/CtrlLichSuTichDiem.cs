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
    }
}
