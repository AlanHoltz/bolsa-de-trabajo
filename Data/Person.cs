using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Bolsa.Data
{
    public class Person : Base
    {
        public Person() : base()
        {

        }

        public List<Entities.Person> GetAll()
        {
            List<Entities.Person> usuarios = new List<Entities.Person>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users u INNER JOIN Persons p ON u.Id = p.Id WHERE u.Status = 1", Conn);

                Conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entities.Person person = new Entities.Person();
                    person.Id = dr.GetInt32(0);
                    person.Mail = dr.GetString(1);
                    person.Type = dr.GetString(3);
                    person.Name = dr.GetString(7);
                    person.Surname = dr.GetString(8);
                    person.BirthDate = dr.GetDateTime(9);
                    person.IsAdmin = dr.GetBoolean(11);

                    usuarios.Add(person);
                }

                dr.Close();
                Conn.Close();

                return usuarios;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entities.Person GetOne(int id)
        {
            List<Entities.Person> usuarios = GetAll();

            Entities.Person usuario = usuarios.FirstOrDefault(u => u.Id.Equals(id));

            return usuario;
        }

        public void Add(Entities.Person user)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Users(Mail, Password, Type, Status, SignupDate) OUTPUT Inserted.Id values(@mail, @password, @type, @status, @signupDate)", Conn);

                cmd.Parameters.AddWithValue("@mail", user.Mail);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@type", "Person");
                cmd.Parameters.AddWithValue("@status", true);
                cmd.Parameters.AddWithValue("@signupDate", DateTime.Now);

                Conn.Open();
                int id = (int)cmd.ExecuteScalar();
                Conn.Close();


                cmd = new SqlCommand("insert into Persons values(@id, @name, @surname, @birthdate, @cv, @isAdmin)", Conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@surname", user.Surname);
                cmd.Parameters.AddWithValue("@birthdate", user.BirthDate);
                cmd.Parameters.AddWithValue("@cv", "");
                cmd.Parameters.AddWithValue("@isAdmin", false);
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();            
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Edit(Entities.Person user)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Users set Password = @password where Id = @id", Conn);

                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@id", user.Id);

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();


                cmd = new SqlCommand("update Persons set Name = @name, Surname = @surname, Birthdate = @birthdate where Id = @id", Conn);

                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@surname", user.Surname);
                cmd.Parameters.AddWithValue("@birthdate", user.BirthDate);
                cmd.Parameters.AddWithValue("@id", user.Id);

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Users set Status = 0 where Id = @id", Conn);

                cmd.Parameters.AddWithValue("@id", id);

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
