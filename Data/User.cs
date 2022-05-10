using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Data
{
    public class User
    {
        public static List<Entities.User> GetAll()
        {
        try 
            { 
                string query = "SELECT * FROM [hola]";
                var users = new List<Entities.User>();
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader != null)
                            {
                                while(reader.Read())
                                {
                                    Entities.User user = new Entities.User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                                    users.Add(user);
                                }
                            }
                        }
                    }
                }
                return users;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
