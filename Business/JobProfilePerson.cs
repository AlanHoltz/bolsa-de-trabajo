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
