using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class Company
    {
        public static List<Entities.Company> GetAll()
        {
            return Data.Company.GetAll();
        }

        public static void Insert(Entities.Company company)
        {
            Data.Company.Insert(company);
        }

        public static void Update(Entities.Company company)
        {
            /*
             * TODO
             * Faltaría hacer acá la subida de imágenes y asignarle la url a
             * company.Photo y con los setters
             */
            company.Photo = "";

            Data.Company.Update(company);
        }
        public static void Delete(Entities.Company company)
        {
            Data.Company.Delete(company);
        }
    }
}
