using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QuanLyVeXemPhim.Utils
{
    class ConnectDB
    {
        private SqlConnection connection;

        public ConnectDB()
        {
            connection = null;
        }

        public SqlConnection getConnection()
        {
            if (connection == null)
            {
                /////
            }
            return connection;
        }


    }

}
