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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users u INNER JOIN Companies c ON u.Id = c.Id WHERE c.Status = 'Authorized'", Conn);

                Conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entities.Company company = new Entities.Company();

                    string photo = dr.GetString(16);

                    company.Id = dr.GetInt32(0);
                    company.Mail = dr.GetString(1);
                    company.Type = dr.GetString(3);
                    company.Name = dr.GetString(7);
                    company.Cuit = dr.GetString(8);
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

    }
}
