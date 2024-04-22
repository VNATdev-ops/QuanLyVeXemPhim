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
                connection = new SqlConnection("Data Source = TAL-70729705\\SQLEXPRESS; "
                      + " Initial Catalog = QL_Ve_Xem_Phim; Integrated Security = true");
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }
            return connection;
        }


    }

}
