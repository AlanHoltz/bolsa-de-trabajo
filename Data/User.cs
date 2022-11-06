using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Bolsa.Data
{
    public class User : Base
    {
        public User() : base()
        {

        }

        public List<Entities.User> GetAll()
        {
            List<Entities.User> users = new List<Entities.User>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users u WHERE u.Status = 1", Conn);

                Conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entities.User user = new Entities.User();
                    user.Id = dr.GetInt32(0);
                    user.Mail = dr.GetString(1);
                    user.Password = dr.GetString(2);
                    user.Type = dr.GetString(3);

                    users.Add(user);
                }

                dr.Close();
                Conn.Close();

                return users;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entities.User GetOne(int id)
        {
            List<Entities.User> users = GetAll();

            Entities.User user = users.FirstOrDefault(u => u.Id.Equals(id));

            return user;
        }

        public Entities.User GetOne(string mail)
        {
            List<Entities.User> users = GetAll();

            Entities.User user = users.FirstOrDefault(u => u.Mail == mail);

            return user;
        }

    }
}
