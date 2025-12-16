using MySql.Data.MySqlClient;
using System;

namespace BTL_QLHSSV_NETFW
{
    internal class dbConn
    {
        private static string connStr = "server=localhost;user=root;password=123456;database=qlhssv;port=3306;";

        public static MySqlConnection GetConnection()
        {
            try
            {
                var conn = new MySqlConnection(connStr);
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Không kết nối được DB", ex);
            }
        }
    }
}
    
