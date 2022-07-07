using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Data
{
    public class Person
    {
        public static List<Entities.Person> GetAll()
        {
        try 
            { 
                string query = "SELECT * FROM [users] u INNER JOIN [persons] p ON u.user_id = p.person_id WHERE u.user_status = 1";
                var users = new List<Entities.Person>();
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
                                    Entities.Person user = new Entities.Person(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Convert.ToBoolean(reader.GetByte(3)), reader.GetDateTime(4), reader.GetString(6), reader.GetString(7), reader.IsDBNull(8) ? "" : reader.GetString(8), reader.IsDBNull(9) ? "" : reader.GetString(9), Convert.ToBoolean(reader.GetByte(10)), reader.GetDateTime(11));
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
        public static void Insert(Entities.Person person)
        {
            try
            {
                string query1 = "INSERT INTO [users] (user_mail, user_password, user_status, user_signup_date) OUTPUT Inserted.user_id VALUES (@EMAIL, @PASSWORD, @STATUS, @FECHAREGISTRO)";
                string query2 = "INSERT INTO [persons] (person_id, person_name, person_surname, person_is_admin, person_birth_date) VALUES (@ID, @NAME, @SURNAME, @IS_ADMIN, @BIRTH_DATE)";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                    {
                        cmd1.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = person.Mail;
                        cmd1.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = person.Password;
                        cmd1.Parameters.Add("@STATUS", SqlDbType.TinyInt).Value = 1;
                        cmd1.Parameters.Add("@FECHAREGISTRO", SqlDbType.Date).Value = DateTime.Now.ToString("dd/MM/yyyy");

                        int id = (int)cmd1.ExecuteScalar();

                        using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                        {
                            cmd2.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                            cmd2.Parameters.Add("@NAME", SqlDbType.VarChar).Value = person.Name;
                            cmd2.Parameters.Add("@SURNAME", SqlDbType.VarChar).Value = person.Surname;
                            cmd2.Parameters.Add("@IS_ADMIN", SqlDbType.TinyInt).Value = person.IsAdmin;
                            cmd2.Parameters.Add("@BIRTH_DATE", SqlDbType.DateTime).Value = person.BirthDate;

                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void Update(Entities.Person person)
        {
            try
            {
                string query1 = "UPDATE [users] SET user_password = @PASSWORD WHERE user_id = @ID";
                string query2 = "UPDATE [persons] SET person_name = @NAME, person_surname = @SURNAME, person_photo = @PHOTO, person_cv = @CV WHERE person_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                    {
                        cmd1.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = person.Password;
                        cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = person.Id;

                        using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                        {
                            cmd2.Parameters.Add("@ID", SqlDbType.Int).Value = person.Id;
                            cmd2.Parameters.Add("@NAME", SqlDbType.VarChar).Value = person.Name;
                            cmd2.Parameters.Add("@SURNAME", SqlDbType.VarChar).Value = person.Surname;
                            cmd2.Parameters.Add("@PHOTO", SqlDbType.VarChar).Value = person.Photo;
                            cmd2.Parameters.Add("@CV", SqlDbType.VarChar).Value = person.Cv;

                            cmd1.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void Delete(Entities.Person person)
        {
            try
            {
                string query1 = "UPDATE [users] SET user_status = @STATUS WHERE user_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                    {
                        cmd1.Parameters.Add("@STATUS", SqlDbType.TinyInt).Value = 0;
                        cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = person.Id;

                        cmd1.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
