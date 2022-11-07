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

        public void Insert(Entities.Company company)
        {
            Data.Company dataCompany = new Data.Company();
            dataCompany.Add(company);
        }

        public void Edit(Entities.Company company)
        {
            Data.Company dataCompany = new Data.Company();
            dataCompany.Edit(company);
        }

        public void Save(Entities.Company company)
        {
            if (company.Id != 0)
            {
                Edit(company);
            }
            else
            {
                Insert(company);
            }
        }

        public void Delete(int id)
        {
            Data.Company dataCompany = new Data.Company();
            dataCompany.Delete(id);
        }
        
        public List<Entities.JobProfile> GetProposals(int companyId)
        {
            Data.Company dataCompany = new Data.Company();
            return dataCompany.GetProposals(companyId);
        }
        
        public Entities.JobProfile GetProposal(int idProposal)
        {
            Data.JobProfile dataJobProfile = new Data.JobProfile();
            return dataJobProfile.GetOne(idProposal);
        }

    }
}
