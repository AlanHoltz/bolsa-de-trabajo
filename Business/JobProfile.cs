using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class JobProfile
    {
        public List<Entities.JobProfile> GetAll(int personId)
        {
            Data.JobProfile jobProfileData = new Data.JobProfile();
            Data.Company companyData = new Data.Company();

            List<Entities.JobProfile> jobProfiles = jobProfileData.GetAll(personId);

            foreach(Entities.JobProfile jobProfile in jobProfiles)
            {
                jobProfile.Company = companyData.GetOne(jobProfile.CompanyId); 
            }

            return jobProfiles;

        }

        public Entities.JobProfile GetOne(int personId, int jobProfileId)
        {
            Data.JobProfile jobProfileData = new Data.JobProfile(); 

            Entities.JobProfile jobProfile = jobProfileData.GetOne(jobProfileId);

            Data.Company companyData = new Data.Company();

            jobProfile.Company = companyData.GetOne(jobProfile.CompanyId);

            return jobProfile;
        }
        
        public void Delete(int jobProfileId)
        {
            Data.JobProfile jobProfileData = new Data.JobProfile(); 

            jobProfileData.Delete(jobProfileId);
        }

    }
}
