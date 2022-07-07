using System;
using System.Data.SqlClient;

namespace Bolsa.Data
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

        public SqlConnection Open() 
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "(localdb)\\MSSQLLocalDb"; 
                builder.UserID = "net";            
                builder.Password = "net";     
                builder.InitialCatalog = "bolsadetrabajo";
            
                SqlConnection conn = new SqlConnection(builder.ConnectionString);
                conn.Open();

                return conn;   
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}