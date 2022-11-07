using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Bolsa.Data
{
    public class Company : Base
    {
        public Company() : base()
        {

        }

        public List<Entities.Company> GetAll()
        {
            List<Entities.Company> companies = new List<Entities.Company>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users u INNER JOIN Companies c ON u.Id = c.Id WHERE u.Status = 1", Conn);

                Conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entities.Company company = new Entities.Company();
                    Entities.City city = new Entities.City();

                    string photo = dr.GetString(16);

                    company.Id = dr.GetInt32(0);
                    company.Mail = dr.GetString(1);
                    company.Type = dr.GetString(3);
                    company.Name = dr.GetString(7);
                    company.Cuit = dr.GetString(8);
                    company.Address = dr.GetString(9);
                    company.ReferenceName = dr.GetString(11);
                    company.ReferencePhone = dr.GetString(12);
                    company.ReferenceEmail = dr.GetString(13);
                    company.ReferenceArea = dr.GetString(14);
                    company.ReferenceWorkingOnCompany = dr.GetString(15);
                    company.Photo = photo != null ? photo : "logo.png";
                    company.Status = dr.GetString(17);

                    companies.Add(company);
                }

                dr.Close();
                Conn.Close();

                return companies;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entities.Company GetOne(int id)
        {
            List<Entities.Company> companies = GetAll();

            Entities.Company company = companies.FirstOrDefault(u => u.Id.Equals(id));

            return company;
        }

        public void Add(Entities.Company user)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Users(Mail, Password, Type, Status, SignupDate) OUTPUT Inserted.Id values(@mail, @password, @type, @status, @signupDate)", Conn);

                cmd.Parameters.AddWithValue("@mail", user.Mail);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@type", "Company");
                cmd.Parameters.AddWithValue("@status", true);
                cmd.Parameters.AddWithValue("@signupDate", DateTime.Now);

                Conn.Open();
                int id = (int)cmd.ExecuteScalar();
                Conn.Close();


                cmd = new SqlCommand("insert into Companies values(@id, @name, @cuit, @address, @zipCode, @referName, @referPhone, @referEmail, @referArea, @referWork, @photo, @status)", Conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@cuit", user.Cuit);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@zipCode", user.CityZipCode);
                cmd.Parameters.AddWithValue("@referName", "");
                cmd.Parameters.AddWithValue("@referPhone", "");
                cmd.Parameters.AddWithValue("@referEmail", "");
                cmd.Parameters.AddWithValue("@referArea", "");
                cmd.Parameters.AddWithValue("@referWork", "");
                cmd.Parameters.AddWithValue("@photo", "");
                cmd.Parameters.AddWithValue("@status", "Pending");

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Edit(Entities.Company user)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Users set Password = @password where Id = @id", Conn);

                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@id", user.Id);

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();


                cmd = new SqlCommand("update Companies set Name = @name, Cuit = @cuit, Address = @address where Id = @id", Conn);

                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@cuit", user.Cuit);
                cmd.Parameters.AddWithValue("@address", user.Address);
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
