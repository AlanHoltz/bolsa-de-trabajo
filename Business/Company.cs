using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class Company
    {
        public List<Entities.Company> GetAll()
        {
            Data.Company dataCompany = new Data.Company();
            return dataCompany.GetAll();
        }

        public Entities.Company GetOne(int id)
        {
            Data.Company dataCompany = new Data.Company();
            return dataCompany.GetOne(id);
        }


    }
}
