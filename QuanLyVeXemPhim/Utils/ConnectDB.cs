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
                connection = new SqlConnection("Data Source = DESKTOP-45GKJAU\\SQLEXPRESS; " +
                   "Initial Catalog = QL_Rap_Chieu_Phim ; Integrated Security = true");
                //ktra kết nối
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            return connection;
        }


    }

}
