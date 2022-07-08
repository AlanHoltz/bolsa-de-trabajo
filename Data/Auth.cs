using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Data
{
    public class Auth
    {
        public static Boolean Login(Entities.User user)
        {
            try
            {
                string query = "SELECT * FROM [users] WHERE user_mail = @MAIL";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MAIL", SqlDbType.VarChar).Value = user.Mail;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader != null)
                            {
                                while (reader.Read())
                                {
                                    // Entities.Person person = new Entities.Person(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Convert.ToBoolean(reader.GetByte(3)), reader.GetDateTime(4), reader.GetString(6), reader.GetString(7), reader.IsDBNull(8) ? "" : reader.GetString(8), reader.IsDBNull(9) ? "" : reader.GetString(9), Convert.ToBoolean(reader.GetByte(10)), reader.GetDateTime(11));
                                    Entities.Person person = new Entities.Person(reader.GetString(1), reader.GetString(2));
                                    if (person.Password == user.Password)
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
                return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}

