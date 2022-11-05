using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Bolsa.Data
{
    public class Base
    {
        public SqlConnection Conn { get; set; }

        public Base()
        {
            string connString = ConfigurationManager.ConnectionStrings["BolsaTrabajo"].ConnectionString;
            Conn = new SqlConnection(connString);
        }

        public void Open()
        {
            Conn.Open();
        }

        public void Close()
        {
            Conn.Close();
        }
    }
}
