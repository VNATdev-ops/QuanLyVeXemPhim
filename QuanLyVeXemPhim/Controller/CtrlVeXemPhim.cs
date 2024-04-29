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
    }
}
