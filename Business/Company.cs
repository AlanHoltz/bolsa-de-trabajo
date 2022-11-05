/* using System;
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
        public Entities.Company GetOne(int ID)
        {
            return Data.Company.GetOne(ID);
        }
        public static void Insert(Entities.Company company)
        {
            Data.Company.Insert(company);
        }

        public static void Update(Entities.Company company)
        {
            company.Photo = "";

            Data.Company.Update(company);
        }
        public static void Delete(Entities.Company company)
        {
            Data.Company.Delete(company);
        }
        public void Save(Entities.Company company)
        {
            Data.Company.Save(company);
        }
    }
}
*/