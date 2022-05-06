using System;
using System.Data.SqlClient;

namespace Utils
{
    public sealed class Singleton
    {
        private static Singleton conn = null;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {


            if (conn == null)
            {
                conn = new Singleton();
            }
            return conn;
        }

        public string connectDB()
        {
            SqlConnection conn;
            string connString = "Data Source=server;Initial Catalog=db;User ID=user;Password=password";
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                Console.WriteLine("Connection Open ! ");
                return connString;
                conn.Close();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}