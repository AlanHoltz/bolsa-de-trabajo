using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class JobProfilePerson
    {

        public Entities.JobProfilePerson GetOne(int jobProfilesId, int personsId)
        {
            Data.JobProfilePerson jobProfilePersonData = new Data.JobProfilePerson();
            
            return jobProfilePersonData.GetOne(jobProfilesId, personsId);
        }

        public List<Entities.JobProfilePerson> GetApplications(int personId)
        {
            Data.JobProfilePerson jobProfilePersonData = new Data.JobProfilePerson();

            List<Entities.JobProfilePerson> applications = jobProfilePersonData.GetApplications(personId);

            foreach(Entities.JobProfilePerson application in applications)
            {

                Data.JobProfile jobProfileData = new Data.JobProfile();
                Entities.JobProfile jobProfile = jobProfileData.GetOne(application.JobProfilesId);

                Data.Company companyData = new Data.Company();
                
                jobProfile.Company = companyData.GetOne(jobProfile.CompanyId);

                application.JobProfiles = jobProfile;

            }

            return applications;

        }

        public void Add(Entities.JobProfilePerson jobProfilePerson)
        {
            Data.JobProfilePerson jobProfilePersonData = new Data.JobProfilePerson();

            jobProfilePersonData.Add(jobProfilePerson);
        }

        public void Delete(int id)
        {
            Data.JobProfilePerson jobProfilePersonData = new Data.JobProfilePerson();
            
            jobProfilePersonData.Delete(id);
        }

    }
}
